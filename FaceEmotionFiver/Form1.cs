using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Emgu.CV.Util;

namespace FaceEmotionFiver
{
    public partial class Form1 : Form
    {
        #region Variables
        private bool FaceDetection = false;
        private bool EnableSave = false;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, Byte>>();
        List<Mat> mats = new List<Mat>();
        List<int> PersonsLabes = new List<int>();
        List<string> PersonsNames = new List<string>();
        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizers;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        static readonly FaceRecognizer recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100);
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        string[] emotions = { "Happy", "Neutral", "Sad" };
        string predictionresult = "";
        int count = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            recognizer.Read("trainer.yml");
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            device = new VideoCaptureDevice(filter[0].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();

        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayimage = new Image<Bgr, byte>(bitmap);


            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayimage, 1.2, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                Image<Bgr, byte> newgrayimage = grayimage;
                newgrayimage.ROI = rectangle;
                Image<Gray, byte> ss = newgrayimage.Convert<Gray, byte>();
                FaceRecognizer.PredictionResult predictionResult = recognizer.Predict(ss);
                predictionresult = emotions[predictionResult.Label];
            }

            pic.Image = bitmap;

            if (predictionresult != "" && count == 20)
            {
                if (device.IsRunning)
                {
                    exitcamera();
                }
            }
            count++;
        }

        private void exitcamera()
        {
            device.SignalToStop();
            device.NewFrame -= new NewFrameEventHandler(Device_NewFrame);
            device = null;
            pic.Image = null;

        }
        private void Predict_Click(object sender, EventArgs e)
        {
            restxt.Text = predictionresult;
        }

        private void btncature_Click(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            device = new VideoCaptureDevice(filter[0].MonikerString);
            device.NewFrame += Device_NewFrames;
            device.Start();

        }

        private void Device_NewFrames(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayimage = new Image<Bgr, byte>(bitmap);
            //currentFrame = eventArgs.Frame.Clone().ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);


            if (FaceDetection == true)
            {

                Rectangle[] faces = cascadeClassifier.DetectMultiScale(grayimage, 1.2, 1);

                foreach (var face in faces)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Red, 1))
                        {
                            graphics.DrawRectangle(pen, face);
                        }
                    }
                    Image<Bgr, byte> resultImage = grayimage;
                    resultImage.ROI = face;
                    picdetected.SizeMode = PictureBoxSizeMode.StretchImage;
                    picdetected.Image = resultImage.Bitmap;
                    if (EnableSave == true)
                    {
                        string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);


                        Task.Factory.StartNew(() =>
                        {
                            for (int i = 0; i < 10; i++)
                            {

                                Debug.WriteLine(resultImage);
                                //resize the image then saving it
                                resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtPersonName.Text + "_" + i.ToString() + ".jpg");
                                Thread.Sleep(1000);

                            }
                        });
                    }
                    EnableSave = false;
                    if (addperson.InvokeRequired)
                    {
                        addperson.Invoke(new ThreadStart(delegate
                        {
                            addperson.Enabled = true;
                        }));
                    }

                    // Step 5: Recognize the face 
                    if (isTrained)
                    {
                        Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                        CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                        var result = recognizers.Predict(grayFaceResult);
                        pictureBox1.Image = grayFaceResult.Bitmap;
                        pictureBox2.Image = TrainedFaces[result.Label].Bitmap;
                        Debug.WriteLine(result.Label + ". " + result.Distance);
                        Debug.WriteLine(PersonsNames[result.Label]);
                        if (result.Label != -1 && result.Distance < 2000)
                        {
                            //CvInvoke.PutText(grayimage, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                            //    FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                            //CvInvoke.Rectangle(grayimage, face, new Bgr(Color.Green).MCvScalar, 2);
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                using (Pen pen = new Pen(Color.Red, 1))
                                {
                                    graphics.DrawString(PersonsNames[result.Label], new Font("Tahoma", 28), Brushes.Red, face);
                                }
                            }
                        }
                        //here results did not found any know faces
                        else
                        {
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                using (Pen pen = new Pen(Color.Red, 1))
                                {
                                    graphics.DrawString("Unknown", new Font("Tahoma", 28), Brushes.Red, face);
                                }
                            }

                        }
                    }
                }

            }
            pic.Image = bitmap;
            if (grayimage != null)
                grayimage.Dispose();
        }

        private void detectfaces_Click(object sender, EventArgs e)
        {
            FaceDetection = true;
        }

        private void addperson_Click(object sender, EventArgs e)
        {
            addperson.Enabled = false;
            EnableSave = true;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }
        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TrainedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    mats.Add(trainedImage.Mat);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    // recognizer = new EigenFaceRecognizer(ImagesCount,Threshold);
                    recognizers = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizers.Train(new VectorOfMat(mats.ToArray()), new VectorOfInt(PersonsLabes.ToArray()));

                    isTrained = true;
                    Debug.WriteLine(ImagesCount);
                    Debug.WriteLine(isTrained);
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return false;
            }

        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace FaceEmotionFiver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.Predict = new System.Windows.Forms.Button();
            this.restxt = new System.Windows.Forms.Label();
            this.btncature = new System.Windows.Forms.Button();
            this.detectfaces = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.addperson = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.picdetected = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 50);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1013, 694);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // Predict
            // 
            this.Predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Predict.Location = new System.Drawing.Point(863, 5);
            this.Predict.Name = "Predict";
            this.Predict.Size = new System.Drawing.Size(128, 39);
            this.Predict.TabIndex = 1;
            this.Predict.Text = "Predict";
            this.Predict.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Predict.UseVisualStyleBackColor = true;
            this.Predict.Click += new System.EventHandler(this.Predict_Click);
            // 
            // restxt
            // 
            this.restxt.AutoSize = true;
            this.restxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restxt.Location = new System.Drawing.Point(274, 12);
            this.restxt.Name = "restxt";
            this.restxt.Size = new System.Drawing.Size(0, 25);
            this.restxt.TabIndex = 2;
            // 
            // btncature
            // 
            this.btncature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncature.Location = new System.Drawing.Point(1040, 50);
            this.btncature.Name = "btncature";
            this.btncature.Size = new System.Drawing.Size(222, 39);
            this.btncature.TabIndex = 3;
            this.btncature.Text = "Capture";
            this.btncature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncature.UseVisualStyleBackColor = true;
            this.btncature.Click += new System.EventHandler(this.btncature_Click);
            // 
            // detectfaces
            // 
            this.detectfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectfaces.Location = new System.Drawing.Point(1040, 95);
            this.detectfaces.Name = "detectfaces";
            this.detectfaces.Size = new System.Drawing.Size(222, 39);
            this.detectfaces.TabIndex = 4;
            this.detectfaces.Text = "DetectFaces";
            this.detectfaces.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.detectfaces.UseVisualStyleBackColor = true;
            this.detectfaces.Click += new System.EventHandler(this.detectfaces_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonName.Location = new System.Drawing.Point(1040, 411);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(216, 30);
            this.txtPersonName.TabIndex = 5;
            // 
            // addperson
            // 
            this.addperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addperson.Location = new System.Drawing.Point(1040, 140);
            this.addperson.Name = "addperson";
            this.addperson.Size = new System.Drawing.Size(222, 39);
            this.addperson.TabIndex = 6;
            this.addperson.Text = "Add Person";
            this.addperson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addperson.UseVisualStyleBackColor = true;
            this.addperson.Click += new System.EventHandler(this.addperson_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(1040, 447);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(222, 39);
            this.btnTrain.TabIndex = 7;
            this.btnTrain.Text = "Train Images";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecognize.Location = new System.Drawing.Point(1040, 492);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(222, 39);
            this.btnRecognize.TabIndex = 8;
            this.btnRecognize.Text = "Recognize Person";
            this.btnRecognize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // picdetected
            // 
            this.picdetected.Location = new System.Drawing.Point(1040, 185);
            this.picdetected.Name = "picdetected";
            this.picdetected.Size = new System.Drawing.Size(216, 220);
            this.picdetected.TabIndex = 9;
            this.picdetected.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1040, 557);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1156, 557);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 756);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picdetected);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.addperson);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.detectfaces);
            this.Controls.Add(this.btncature);
            this.Controls.Add(this.restxt);
            this.Controls.Add(this.Predict);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button Predict;
        private System.Windows.Forms.Label restxt;
        private System.Windows.Forms.Button btncature;
        private System.Windows.Forms.Button detectfaces;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button addperson;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.PictureBox picdetected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


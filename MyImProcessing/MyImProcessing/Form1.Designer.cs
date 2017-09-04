namespace MyImProcessing
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
            this.original_picture = new System.Windows.Forms.PictureBox();
            this.processed_picture = new System.Windows.Forms.PictureBox();
            this.Open_Image = new System.Windows.Forms.Button();
            this.make_it_gray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.original_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // original_picture
            // 
            this.original_picture.Location = new System.Drawing.Point(23, 18);
            this.original_picture.Name = "original_picture";
            this.original_picture.Size = new System.Drawing.Size(582, 497);
            this.original_picture.TabIndex = 0;
            this.original_picture.TabStop = false;
            // 
            // processed_picture
            // 
            this.processed_picture.Location = new System.Drawing.Point(641, 18);
            this.processed_picture.Name = "processed_picture";
            this.processed_picture.Size = new System.Drawing.Size(582, 497);
            this.processed_picture.TabIndex = 1;
            this.processed_picture.TabStop = false;
            // 
            // Open_Image
            // 
            this.Open_Image.Location = new System.Drawing.Point(222, 548);
            this.Open_Image.Name = "Open_Image";
            this.Open_Image.Size = new System.Drawing.Size(184, 74);
            this.Open_Image.TabIndex = 2;
            this.Open_Image.Text = "Open Image";
            this.Open_Image.UseVisualStyleBackColor = true;
            this.Open_Image.Click += new System.EventHandler(this.Open_Image_Click);
            // 
            // make_it_gray
            // 
            this.make_it_gray.Location = new System.Drawing.Point(840, 548);
            this.make_it_gray.Name = "make_it_gray";
            this.make_it_gray.Size = new System.Drawing.Size(184, 74);
            this.make_it_gray.TabIndex = 3;
            this.make_it_gray.Text = "Gray";
            this.make_it_gray.UseVisualStyleBackColor = true;
            this.make_it_gray.Click += new System.EventHandler(this.make_it_gray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 665);
            this.Controls.Add(this.make_it_gray);
            this.Controls.Add(this.Open_Image);
            this.Controls.Add(this.processed_picture);
            this.Controls.Add(this.original_picture);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.original_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processed_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox original_picture;
        private System.Windows.Forms.PictureBox processed_picture;
        private System.Windows.Forms.Button Open_Image;
        private System.Windows.Forms.Button make_it_gray;
    }
}


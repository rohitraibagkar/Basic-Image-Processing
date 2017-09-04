using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyImProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileImage = new OpenFileDialog();
            openFileImage.Filter = "Image File(*.bmp, *.jpg)|*.bmp; *.jpg";

            if (DialogResult.OK == openFileImage.ShowDialog())
            {
                this.original_picture.Image = new Bitmap(openFileImage.FileName);
            }
        }

        private void make_it_gray_Click(object sender, EventArgs e)
        {
            Bitmap gray_img = new Bitmap((Bitmap)this.original_picture.Image);
            imProcessor.Convert2Gray(gray_img);
            this.processed_picture.Image = gray_img;
        }
    }
}

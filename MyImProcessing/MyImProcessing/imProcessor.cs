using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyImProcessing
{
    class imProcessor
    {
        public imProcessor()
        {

        }

        public static bool Convert2Gray (Bitmap img)
        {
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color clr = img.GetPixel(i, j);
                    int r1 = clr.R;
                    int g1 = clr.G;
                    int b1 = clr.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    img.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
        }
    }
}

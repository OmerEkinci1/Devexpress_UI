using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgteksDemo_UI.Helpers
{
    public static class BitmapHelper
    {
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Bmp);
            return ms.ToArray();
        }

        public static Bitmap ByteArrayToImage(byte[] source)
        {
            using (var ms = new MemoryStream(source))
            {
                return new Bitmap(ms);
            }
        }
    }
}

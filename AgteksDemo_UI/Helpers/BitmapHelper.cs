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

        public static Bitmap Base64StringToBitmap(string base64string)
        {
            Bitmap bmpReturn = null;

            byte[] byteBuffer = Convert.FromBase64String(base64string);
            MemoryStream memorStream = new MemoryStream(byteBuffer);

            memorStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memorStream);

            memorStream.Close();
            memorStream = null;
            byteBuffer = null;

            return bmpReturn;
        }
    }
}

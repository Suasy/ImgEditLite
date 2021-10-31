using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgEdit
{
    public class BitmapUtils
    {
        public static byte[] Bitmap2Byte(Bitmap bitmap)
        {
            using (Stream stream1 = new MemoryStream())
            {
                bitmap.Save(stream1, ImageFormat.Jpeg);
                byte[] arr = new byte[stream1.Length];
                stream1.Position = 0;
                stream1.Read(arr, 0, (int)stream1.Length);
                stream1.Close();
                return arr;
            }
        }

        public static Bitmap Byte2Bitmap(byte[] bytes)
        {
            byte[] bytelist = bytes;
            Bitmap bitmap;
            using (MemoryStream ms1 = new MemoryStream(bytelist))
            {
                bitmap = (Bitmap)Image.FromStream(ms1);
                ms1.Close();
            }
            return bitmap;
        }

        public static string Bitmap2String(Bitmap bitmap)
        {
            return System.Convert.ToBase64String(Bitmap2Byte(bitmap));
        }

        public static Bitmap String2Bitmap(string str)
        {
            return Byte2Bitmap(System.Convert.FromBase64String(str));
        }
    }
}

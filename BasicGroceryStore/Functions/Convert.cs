using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace BasicGroceryStore
{
    internal static class Convert
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image img = Image.FromStream(ms, true);
            return img;
        }
    }
}

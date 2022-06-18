using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace BasicGroceryStore
{
    public class AdditionalFunctions
    {
        public static string MakeIDByTime()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                   DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
        }

        public static string getDateString(DateTime date)
        {
            return date.Year + "-" + date.Month + "-" + date.Day;
        }

        public static byte[] ConvertImageToByteArray(Image image)
        {
            if(image == null)
                return null;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        } 

        public static Image ConvertByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image img = Image.FromStream(ms, true);
            return img;
        }

    }

    public enum TypeWork { parttime, fulltime }

    public enum Spells { morning, evening, night }

    public enum Level { // Level of Customer member
        None, 
        Copper, 
        Silver, 
        Golden, 
        Platinum 
    }

    public enum StatusOfConstract {
        Unexpired,
        Expiration_Soon,
        Expired
    }
}

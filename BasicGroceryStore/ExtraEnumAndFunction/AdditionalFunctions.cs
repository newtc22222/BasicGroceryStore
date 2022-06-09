using System;

namespace BasicGroceryStore
{
    public class AdditionalFunctions
    {
        public static string MakeIDByTime()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                   DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
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

    public enum SettingAccount
    {
        Login,
        Logout,
        Information,
        Support
    }
}

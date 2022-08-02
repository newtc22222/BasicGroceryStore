namespace BasicGroceryStore
{
    /// <summary>
    /// Menu in Main Form
    /// </summary>
    public enum SettingControl
    {
        LOGIN,
        LOGOUT,
        SUPPORT,
        INFORMATION,
        EXIT
    }

    /// <summary>
    /// Global version
    /// </summary>
    public enum Gender
    {
        Male,
        Female,
        Another
    }

    /// <summary>
    /// Vietnam version
    /// </summary>
    public enum GenderVietnamese
    {
        nam, 
        nữ,
        khác
    }

    /// <summary>
    /// Type of work
    /// </summary>
    public enum TypeWork 
    { 
        parttime, 
        fulltime 
    }

    /// <summary>
    /// Using for part-time job
    /// </summary>
    public enum Spells 
    { 
        morning, 
        afternoon, 
        night 
    }

    /// <summary>
    /// Level of Customer Member
    /// </summary>
    public enum Level
    { 
        None,
        Copper,
        Silver,
        Golden,
        Platinum
    }

    /// <summary>
    /// Using for checking Contract of Staff
    /// </summary>
    public enum StatusOfContract
    {
        Unexpired,
        Expiration_Soon,
        Expired
    }
}

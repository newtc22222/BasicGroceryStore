using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BasicGroceryStore
{
    /// <summary>
    /// Using for save store information and remember account (with xml file)
    /// </summary>
    public class DAO_Information
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;

        private string path = Path.GetDirectoryName(Directory.GetCurrentDirectory());
        private string using_path;

        public DAO_Information(string fileName)
        {
            path = path.Replace("bin", "Data/");
            using_path = path + fileName;
            doc.Load(using_path);
            root = doc.DocumentElement;
        }

        /// <summary>
        /// Get new information of store
        /// </summary>
        /// <param name="data"></param>
        public void UpdateInformation(Dictionary<string, string> data = null)
        {            
            XmlNode new_information = doc.CreateElement("information");

            XmlNode new_address = doc.CreateElement("address");
            new_address.InnerText = data["address"];
            new_information.AppendChild(new_address);

            XmlNode new_email = doc.CreateElement("email");
            new_email.InnerText = data["email"];
            new_information.AppendChild(new_email);

            XmlNode new_phone = doc.CreateElement("phone");
            new_phone.InnerText = data["phone"];
            new_information.AppendChild(new_phone);

            // LINK
            XmlNode new_link = doc.CreateElement("link");

            XmlNode new_link_map = doc.CreateElement("map");
            new_link_map.InnerText = data["link_map"];
            new_link.AppendChild(new_link_map);

            XmlNode new_link_fb = doc.CreateElement("facebook");
            new_link_fb.InnerText = data["link_fb"];
            new_link.AppendChild(new_link_fb);

            XmlNode new_link_ig = doc.CreateElement("instagram");
            new_link_ig.InnerText = data["link_ig"];
            new_link.AppendChild(new_link_ig);

            XmlNode new_link_linkedin = doc.CreateElement("linkedin");
            new_link_linkedin.InnerText = data["link_linkedin"];
            new_link.AppendChild(new_link_linkedin);

            XmlNode new_link_ut = doc.CreateElement("youtube");
            new_link_ut.InnerText = data["link_ut"];
            new_link.AppendChild(new_link_ut);

            new_information.AppendChild(new_link);

            root.ReplaceChild(new_information, root.FirstChild);
            doc.Save(using_path);
        }

        /// <summary>
        /// Take information and bring it to GUI
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> LoadStoreInformation()
        {
            Dictionary<string, string> information = new Dictionary<string, string>();

            XmlNode xml_data = root.FirstChild;
            information["address"] = xml_data["address"].InnerText;
            information["email"] = xml_data["email"].InnerText;
            information["phone"] = xml_data["phone"].InnerText;

            information["link_map"] = xml_data["link"].ChildNodes[0].InnerText;
            information["link_fb"] = xml_data["link"].ChildNodes[1].InnerText;
            information["link_ig"] = xml_data["link"].ChildNodes[2].InnerText;
            information["link_linkedin"] = xml_data["link"].ChildNodes[3].InnerText;
            information["link_ut"] = xml_data["link"].ChildNodes[4].InnerText;

            return information;
        }

        /// <summary>
        /// Update data in Account.xml
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="isSave"></param>
        public void UpdateSaveAccount(Account acc, bool isSave)
        {
            XmlNode new_data = doc.CreateElement("Account");

            XmlNode staff_id = doc.CreateElement("staff_id");
            staff_id.InnerText = "";

            XmlNode username = doc.CreateElement("username");
            username.InnerText = "";

            XmlNode password = doc.CreateElement("password");
            password.InnerText = "";

            XmlNode is_save = doc.CreateElement("is_save");
            is_save.InnerText = isSave.ToString();

            if (isSave)
            { 
                staff_id.InnerText = acc.Staff_id;
                username.InnerText = acc.Username;
                password.InnerText = acc.Password;
            } 

            new_data.AppendChild(staff_id);
            new_data.AppendChild(username);
            new_data.AppendChild(password);
            new_data.AppendChild(is_save);

            root.ReplaceChild(new_data, root.FirstChild);
            doc.Save(using_path);
        }

        /// <summary>
        /// Take SaveAccount in Account.xml and bring it to Login form 
        /// </summary>
        /// <returns></returns>
        public List<object> LoadSaveAccount()
        {
            List<object> data = new List<object>();

            XmlNode xml_data = root.FirstChild;
            data.Add(xml_data["staff_id"].InnerText);
            data.Add(xml_data["username"].InnerText);
            data.Add(xml_data["password"].InnerText);
            data.Add(xml_data["is_save"].InnerText);

            return data;
        }
    }
}

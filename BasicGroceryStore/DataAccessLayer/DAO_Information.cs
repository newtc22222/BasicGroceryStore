using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace BasicGroceryStore
{
    public class DAO_Information // FOR XML FILE
    {
        private static XmlDocument doc = new XmlDocument();
        private static XmlElement root;

        private static string path = Path.GetDirectoryName(Directory.GetCurrentDirectory());
        private static string using_path;

        public DAO_Information(string fileName)
        {
            path = path.Replace("bin", "ExtraData/");
            using_path = path + fileName;
            doc.Load(using_path);
            root = doc.DocumentElement;
        }

        public void updateInformation(string address, string email, string phone, 
            string link_map, string link_fb, string link_ig, string link_linkedin, string link_ut)
        {            
            XmlNode new_information = doc.CreateElement("information");

            XmlNode new_address = doc.CreateElement("address");
            new_address.InnerText = address;
            new_information.AppendChild(new_address);

            XmlNode new_email = doc.CreateElement("email");
            new_email.InnerText = email;
            new_information.AppendChild(new_email);

            XmlNode new_phone = doc.CreateElement("phone");
            new_phone.InnerText = phone;
            new_information.AppendChild(new_phone);

            // LINK
            XmlNode new_link = doc.CreateElement("link");

            XmlNode new_link_map = doc.CreateElement("map");
            new_link_map.InnerText = link_map;
            new_link.AppendChild(new_link_map);

            XmlNode new_link_fb = doc.CreateElement("facebook");
            new_link_fb.InnerText = link_fb;
            new_link.AppendChild(new_link_fb);

            XmlNode new_link_ig = doc.CreateElement("instagram");
            new_link_ig.InnerText = link_ig;
            new_link.AppendChild(new_link_ig);

            XmlNode new_link_linkedin = doc.CreateElement("linkedin");
            new_link_linkedin.InnerText = link_linkedin;
            new_link.AppendChild(new_link_linkedin);

            XmlNode new_link_ut = doc.CreateElement("youtube");
            new_link_ut.InnerText = link_ut;
            new_link.AppendChild(new_link_ut);

            new_information.AppendChild(new_link);

            root.ReplaceChild(new_information, root.FirstChild);
            doc.Save(using_path);
        }

        public List<string> loadInformation()
        {
            List<string> information = new List<string>();

            XmlNode xml_data = root.FirstChild;
            information.Add(xml_data["address"].InnerText);
            information.Add(xml_data["email"].InnerText);
            information.Add(xml_data["phone"].InnerText);

            information.Add(xml_data["link"].ChildNodes[0].InnerText); // map
            information.Add(xml_data["link"].ChildNodes[1].InnerText); // fb
            information.Add(xml_data["link"].ChildNodes[2].InnerText); // ig
            information.Add(xml_data["link"].ChildNodes[3].InnerText); // linkedin
            information.Add(xml_data["link"].ChildNodes[4].InnerText); // utube


            return information;
        }

        public void updateSaveAccount(Account acc, bool isSave)
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

        public List<object> loadSaveAccount()
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetSoftwareAndSupport
{
    public partial class Record_Comment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod()]
        public static void UploadImage(string imageData)
        {
            string fileNameWitPath = "";
           //string fileNameWitPath = "c\\:adsf" + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "- ").Replace(":", "") + ".png";
           // using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
           // {
           //     using (BinaryWriter bw = new BinaryWriter(fs))
           //     {
           //         byte[] data = Convert.FromBase64String(imageData);
           //         bw.Write(data);
           //         bw.Close();

           //     }
           // }
        }
     
    [System.Web.Services.WebMethod]
        public static string C_Sharp_Save_Image(string imagedata)
        {
            string value1 = "";
            //var base64Data = Regex.Match(imagedata, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
            int res1insert = 99433;

            byte[] file;
                file  = System.Text.Encoding.ASCII.GetBytes(imagedata);
            using (var stream = new FileStream(imagedata, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            try
            {
              //  string filename = Path.GetFileName(openFileDialog1.FileName);


                //   MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection();


                //  string constr = cn.connection_to_use;
                string constr = "Server=198.71.225.50;Port=3306;Database=dbGetSoftAndSup;Uid=uGetSoftAndSup;Pwd=Gillion_75;";
                //  con.ConnectionString = "Server=198.71.225.50;Port=3306;Database=dbGetSoftAndSup;Uid=uGetSoftAndSup;Pwd=Gillion_75;";
                using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(constr))
                {
                    string query = "INSERT INTO tbl_Record_Comment(" +
                            "Id, " +
                            "First_Name, " +
                               "Middle_Name, " +
                                    "Last_Name, " +
                                        "Username, " +
                                           "Password, " +
                                              "Email, " +
                                                 "Phone, " +
                                                    "Approved, " +
                                                    "The_Image" +
                            ") VALUES (" +
                           "@Id" +
                            ", " +
                            "@First_Name" +
                            ", " +
                               "@Middle_Name" +
                            ", " +
                               "@Last_Name" +
                            ", " +
                               "@Username" +
                            ", " +
                               "@Password" +
                            ", " +
                               "@Email" +
                            ", " +
                               "@Phone" +
                            ", " +
                                "@Approved" +
                            ", " +
                            "@The_Image" +
                            ")";
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
                    {
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                        cmd.Parameters.AddWithValue("@First_Name", "tt");
                        cmd.Parameters.AddWithValue("@Middle_Name", "tt");
                        cmd.Parameters.AddWithValue("@Last_Name", "tt");
                        cmd.Parameters.AddWithValue("@Username", "tt");
                        cmd.Parameters.AddWithValue("@Password", "tt");
                        cmd.Parameters.AddWithValue("@Email", "tt");
                        cmd.Parameters.AddWithValue("@Phone", "tt");
                        cmd.Parameters.AddWithValue("@Approved", 0);
                        cmd.Parameters.AddWithValue("@The_Image", file);
                        con.Open();
                        res1insert = cmd.ExecuteNonQuery();
                        con.Close();
                        value1 = "saved";
                    }
                }



            }
            catch (Exception eee)
            {
                string jjdd = eee.ToString();
                value1 = "error";
            }


            return value1;

        }



        public string UploadWebCamImage(string imageData)
        {
            string filename = Server.MapPath("~/UploadWebcamImages/webcam_") + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "_").Replace(":", "") + ".png";
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    byte[] data = Convert.FromBase64String(imageData);
                    bw.Write(data);
                    bw.Close();
                }
            }
            return "success";
        }
    }
}
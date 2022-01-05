using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
 

namespace GetSoftwareAndSupport
{
   
    public partial class Session_Test : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


            if (Context.Request.Files.Count > 0)

            {
                HttpPostedFile postedFile = Context.Request.Files[0];
                //  HttpPostedFile postedFile = HttpContext.Current.Request.Files[0];
                //  HttpPostedFile postedFile = Context.Request.Files[0];
                // ProcessRequest1(Context);
                ProcessRequest1(postedFile);
            }

              
        }

        [System.Web.Services.WebMethod] 
        public  string ProcessRequest1(HttpPostedFile the_postedfile)
        {

            StringBuilder String_builder_what_to_return = new StringBuilder();
            String_builder_what_to_return.AppendLine("Processed Request...");



            string usersTextbox_session_frompreviouspage = Context.Request.QueryString["Name"];
            string Name = usersTextbox_session_frompreviouspage;
            String_builder_what_to_return.AppendLine(Name);
            if (usersTextbox_session_frompreviouspage != null)
            {
                ////// there is  a null emall

                /// run it







               // HttpPostedFile postedFile = context.Request.Files[0];

                if (the_postedfile != null)
                {
                    String_builder_what_to_return.AppendLine("Found file.");

                    string folderPath = Context.Server.MapPath("/MyRecordedVideos/");
                    String_builder_what_to_return.AppendLine(folderPath.ToString());
                    string fileName = Path.GetFileName(the_postedfile.FileName);
                    Guid g = Guid.NewGuid();
                    string gstring = g.ToString() + ".mp4";


                    #region Save database now


                    string the_link_to_use = "https://getsoftwareandsupport.com/MyRecordedVideos/";
                    if (folderPath.ToString().ToLower().Contains(@"c:\"))
                    {
                        the_link_to_use = "https://localhost:44333/MyRecordedVideos/";
                    }

                    the_link_to_use = the_link_to_use + fileName + gstring;
                    try
                    {
                        DateTime theDate1 = DateTime.Now;

                        var connection = new Connection_Strings();

                        using (MySqlConnection con = new MySqlConnection(connection.prod_conn_string.ToString()))
                        {
                            con.Open();
                            MySqlCommand comm = con.CreateCommand();
                            comm.Parameters.AddWithValue("@Email", Name);
                            comm.Parameters.AddWithValue("@link", the_link_to_use);
                            comm.Parameters.AddWithValue("@folder", @folderPath);
                            comm.Parameters.AddWithValue("@Organization", Name);
                            comm.Parameters.AddWithValue("@Block", 0);
                            comm.Parameters.AddWithValue("@the_date", theDate1);
                            //   string StringommandText = "INSERT INTO getsoftware_Links6(email , link , folder , Organization, Block) VALUES ( @email , @link , @folder, @Organization, @Block)";
                            string StringommandText = "INSERT INTO getsoftware_Links7(email , link , folder , Organization, Block ,the_date) VALUES ( @email , @link , @folder, @Organization, @Block ,@the_date)";
                            //create table getsoftware_Links7( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , Email varchar(255) NOT NULL , link VARCHAR(255), folder varchar(500) NOT NULL , Organization varchar(255) NOT NULL , Block int(11) NOT NULL, the_date TIMESTAMP NOT NULL )
                            comm.CommandText = StringommandText;

                            try
                            {
                                comm.ExecuteNonQuery();
                                String_builder_what_to_return.AppendLine("Inserted Record.");
                            }
                            catch (Exception ex)
                            {
                                string msg = ex.Message.ToString().Replace("'", "");
                                String_builder_what_to_return.AppendLine(msg);

                            }


                            try
                            {
                                comm.Dispose();

                            }
                            catch (Exception ex)
                            {
                                string msg = ex.Message.ToString().Replace("'", "");
                                String_builder_what_to_return.AppendLine(msg);

                            }



                        }

                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message.ToString().Replace("'", "");
                        String_builder_what_to_return.AppendLine(msg);

                    }

                    #endregion
                    #region Save to_server now

                    try
                    {

                        the_postedfile.SaveAs(@folderPath + fileName + gstring);

                    }
                    catch (Exception ex)
                    {
                        String_builder_what_to_return.AppendLine("Could not save file to server.");
                        string msg = ex.Message.ToString().Replace("'", "");
                        String_builder_what_to_return.AppendLine(msg);


                    }





                    #endregion












                }

                else
                {

                    String_builder_what_to_return.AppendLine("There is a null file.");
                }


            }
            else
            {
                ///// There is not a null email
                String_builder_what_to_return.AppendLine("There is a null file.");
            }


            #region Write JsonMessage
            var my_jsondata = new
            {
                success = true,
                //responseText = "it worked",
                responseText = String_builder_what_to_return.ToString()
            };


            string json_data = JsonConvert.SerializeObject(my_jsondata);



            Context.Response.ContentType = "application/json; charset=utf-8";
            Context.Response.Write(json_data);
            Context.Response.Cache.SetCacheability(HttpCacheability.NoCache);

            #endregion
            return "";
        }

        public string Decrypt(string cipherText)
        {



            try
            {

                string EncryptionKey = "62e24b33099d46e88389d72ef814219a";
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (System.IO.MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return cipherText;


            }
            catch (Exception jerror1)
            {
                string jj = jerror1.ToString();


              //  Error_Redirect("/Account/AccessDenied");

                return "";

            }



        }
    }
}
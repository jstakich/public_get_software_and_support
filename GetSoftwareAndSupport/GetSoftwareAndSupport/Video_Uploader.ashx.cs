using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using System.Diagnostics;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using System.DirectoryServices;
using System.Data.SqlClient;
using System.Net.Mail;
using System.DirectoryServices.AccountManagement;
using System.Web.Services;

using System.Collections.Specialized;
using System.Web.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using System.Globalization;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;
using System.Web.Http;

namespace GetSoftwareAndSupport
{
    /// <summary>
    /// Summary description for Video_Uploader
    /// </summary>
   // public class ImageHandler : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    public class Video_Uploader : IHttpHandler
    {

        bool IHttpHandler.IsReusable => throw new NotImplementedException();

        [WebMethod(EnableSession = true)]
        public void ftpfile(HttpPostedFile postedFile)
        {
            try
            {
                
                string info1 = "";
                info1 = "Video is uploading ...";
               // tb_info.Refresh();
               // tb_info.Refresh();
               // this.Refresh();

                //  ftp://107.180.63.53/httpdocs/files/Main_App/
                string ftphost = "safd";
                //here correct hostname or IP of the ftp server to be given



                string ftpfullpath = "ftp://" + ftphost + "/httpdocs/files/Videos/" + postedFile.FileName;


                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential("safd", "asfd");
                //userid and password for the ftp server to given

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;
                FileStream fs = File.OpenRead(postedFile.FileName);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                Stream ftpstream = ftp.GetRequestStream();
                ftpstream.Write(buffer, 0, buffer.Length);
                ftpstream.Close();
              //  AutoClosingMessageBox.Show("This video has been uploaded to GetSoftwareAndSupport.com .", "Reahard & Associates - IT Department", 2000);
              //  tb_info.Text = "This video has been uploaded to GetSoftwareAndSupport.com";
               // tb_info.Refresh();
               // this.Refresh();
            }
            catch (Exception ex)
            {
                //AutoClosingMessageBox.Show(ex.ToString(), "Reahard & Associates - IT Department", 2000);

            }


        }
        //https://www.aspsnippets.com/Articles/Upload-Save-Retrieve-and-Play-MP4-Video-files-with-live-streaming-from-Database-in-ASPNet-using-C-and-VBNet.aspx


        //public void ProcessRequest(HttpContext context)
        //{

        //    if (context.Request.Files.Count > 0)
        //    {
        //        //Fetch the Uploaded File.
        //        HttpPostedFile postedFile = context.Request.Files[0];
        //        if (postedFile != null)
        //                {

        //            try
        //            {
        //            string info1 = "";
        //            info1 = "Video is uploading ...";
        //            // tb_info.Refresh();
        //            // tb_info.Refresh();
        //            // this.Refresh();

        //            //  ftp://107.180.63.53/httpdocs/files/Main_App/
        //            string ftphost = "safd";
        //            //here correct hostname or IP of the ftp server to be given



        //            string ftpfullpath = "ftp://" + ftphost + "/httpdocs/files/Videos/" + postedFile.FileName;


        //            FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
        //            ftp.Credentials = new NetworkCredential("safd", "asfd");
        //            //userid and password for the ftp server to given

        //            ftp.KeepAlive = true;
        //            ftp.UseBinary = true;
        //            ftp.Method = WebRequestMethods.Ftp.UploadFile;
        //            //FileStream fs = File.OpenRead(postedFile.FileName);
        //                FileStream fs = File.OpenRead(context.Server.MapPath(postedFile.FileName));
        //                byte[] buffer = new byte[fs.Length];
        //            fs.Read(buffer, 0, buffer.Length);
        //            fs.Close();
        //            Stream ftpstream = ftp.GetRequestStream();
        //            ftpstream.Write(buffer, 0, buffer.Length);
        //            ftpstream.Close();
        //            //  AutoClosingMessageBox.Show("This video has been uploaded to GetSoftwareAndSupport.com .", "Reahard & Associates - IT Department", 2000);
        //            //  tb_info.Text = "This video has been uploaded to GetSoftwareAndSupport.com";
        //            // tb_info.Refresh();
        //            // this.Refresh();
        //        }
        //        catch (Exception ex)
        //        {
        //            //AutoClosingMessageBox.Show(ex.ToString(), "Reahard & Associates - IT Department", 2000);

        //        }
        //        return;




        //        // ftpfile(postedFile);
        //        ////return;
        //        //Set the Folder Path.
        //        string folderPath = context.Server.MapPath("/files/Videos/");

        //        //Set the File Name.
        //        string fileName = Path.GetFileName(postedFile.FileName);

        //        //Save the File in Folder.
        //        Guid g = Guid.NewGuid();
        //        string gstring = g.ToString() + ".mp4";
        //        Console.WriteLine(gstring);
        //        postedFile.SaveAs(folderPath + gstring);
        //        //   string newpath = "https://getsoftwareandsupport.com/Uploads/" + gstring;
        //        string newpath = "/files/Videos/" + gstring;
        //        //Send File details in a JSON Response.
        //        string json = new JavaScriptSerializer().Serialize(
        //            new
        //            {
        //                name = fileName
        //            });
        //        context.Response.StatusCode = (int)HttpStatusCode.OK;
        //        context.Response.ContentType = "video/mp4";
        //        context.Response.Write(json);
        //        string saythis = "Your video was uploaded to" + newpath;
        //        //string script = "alert(\"Hello!\");";
        //        //System.Windows.Forms.MessageBox.Show(saythis);
        //        App_Vars.link_to_video = newpath;
        //        context.Response.End();


        //    }
        //        //var formData = context.Request.Form; // Get the form object from the current HTTP request.

        //        //foreach (var formVariable in formData)
        //        //{
        //        //    var value = formData[formVariable.ToString()].ToString();
        //        //}
        //    }
        //}

        //
        //      context.Request.Form["SearchKey"].ToString();
        //  }
        [WebMethod(EnableSession = true)]
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


                Error_Redirect("/Account/AccessDenied");

                return "";

            }



        }

        [WebMethod(EnableSession = true)]
        /// <summary>
        /// redirect on error
        /// </summary>
        /// <param name="Redirect_Location"></param>
        protected void Error_Redirect(string Redirect_Location)
        {
            try
            {


                try
                {

                   
                }
                catch (Exception jerror1FF)
                {

                    string eee = jerror1FF.ToString();

                }

            }
            catch (Exception jerror1)
            {
                string eee = jerror1.ToString();
                Error_Redirect("/Account/AccessDenied");
                return;
            }

        }
        //[WebMethod(EnableSession = true)]

        [HttpPost()]
        public void ProcessRequest(HttpContext context)
    {
           
            StringBuilder String_builder_what_to_return = new StringBuilder();
            String_builder_what_to_return.AppendLine("Processed Request...");

          

            string usersTextbox_session_frompreviouspage = context.Request.QueryString["Name"];
            string Name = usersTextbox_session_frompreviouspage;
            String_builder_what_to_return.AppendLine(Name);
            if (usersTextbox_session_frompreviouspage != null)
            {
                ////// there is  a null emall

                /// run it



          



            HttpPostedFile postedFile = context.Request.Files[0];
             
                if (postedFile != null)
                {
                    String_builder_what_to_return.AppendLine("Found file.");

                    string folderPath = context.Server.MapPath("/MyRecordedVideos/");
                    String_builder_what_to_return.AppendLine(folderPath.ToString());
                    string fileName = Path.GetFileName(postedFile.FileName);
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
                 
                postedFile.SaveAs(@folderPath + fileName + gstring);

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
                 responseText = "it worked",
               // responseText = String_builder_what_to_return.ToString()
            };

             
           // string json_data = JsonConvert.SerializeObject(my_jsondata);

            

          //  context.Response.ContentType = "application/json; charset=utf-8";
          ////  context.Response.Write(json_data);
          //  context.Response.Write(my_jsondata);
          //  context.Response.Cache.SetCacheability(HttpCacheability.NoCache);

            #endregion
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }


}
//public void ProcessRequest(HttpContext context)
//{

//    if (Request.Form.Files.Any())
//    {
//    }

//    string Name = "";
//    if (context.Session["Username_to_use"] != null)
//        Name = context.Session["Username_to_use"].ToString();
//    {
//        string Namess = context.Session["Username_to_use"].ToString();
//    }
//    Name = Decrypt(Name);

//    if (context.Request.Files.Count > 0)
//    {
//        //Fetch the Uploaded File.
//        HttpPostedFile postedFile = context.Request.Files[0];
//        if (postedFile != null)
//        {


//            //Set the Folder Path.
//            string folderPath = context.Server.MapPath("~/Uploads/");

//            //Set the File Name. Example 'Blob
//            string fileName = Path.GetFileName(postedFile.FileName);
//            //  string the_link_to_use = "https://getsoftwareandsupport.com/files/Videos/fe0a55ae-cde7-4e56-93cf-8fb3fec1236e.mp4"
//            string the_link_to_use = "https://getsoftwareandsupport.com/files/Videos/";

//            //Save the File in Folder.
//            Guid g = Guid.NewGuid();
//            string gstring = g.ToString() + ".mp4";
//            the_link_to_use = the_link_to_use + gstring;
//            Console.WriteLine(gstring);
//            // postedFile.SaveAs(folderPath + gstring);

//            try
//            {
//                //   string ftpAddress = "127.0.0.1";
//                string username = "juploadaccount";
//                string password = "9937646hfhsksifuyfytd5e6de8847";
//                string ftphost1 = "107.180.63.53";
//                //using (StreamReader stream = new StreamReader(postedFile.InputStream))
//                //{
//                using (BinaryReader br = new BinaryReader(postedFile.InputStream))
//                {
//                    byte[] bytes = br.ReadBytes((int)postedFile.InputStream.Length);


//                    //create table getsoftware_Links1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , link VARCHAR(1000) NOT NULL , Organization VARCHAR(255) NOT NULL , Block INT NOT NULL )

//                    string cs = "Server=1afsd;Port=3306;Database=asfd;Uid=sfad;Pwd=safd;";

//                    //WebRequest request = WebRequest.Create("ftp://" + ftphost1 + "/httpdocs/files/Videos/" + gstring + ".mp4");
//                    WebRequest request = WebRequest.Create("ftp://" + ftphost1 + "/httpdocs/files/Videos/" + gstring);
//                    //     WebRequest request = WebRequest.Create("ftp://" + ftphost1 + "/httpdocs/files/Videos/" + gstring );
//                    request.Method = WebRequestMethods.Ftp.UploadFile;
//                    request.Credentials = new NetworkCredential(username, password);
//                    //request.ContentType = "video/mp4";
//                    Stream reqStream = request.GetRequestStream();

//                    reqStream.Write(bytes, 0, bytes.Length);
//                    reqStream.Close();
//                    reqStream.Dispose();

//                    using (MySqlConnection con = new MySqlConnection(cs))
//                    {
//                        con.Open();
//                        MySqlCommand comm = con.CreateCommand();
//                        //  comm.Parameters.AddWithValue("@id", txt_Security_Question1.Text);
//                        comm.Parameters.AddWithValue("@Email", Name);
//                        comm.Parameters.AddWithValue("@link", the_link_to_use);
//                        comm.Parameters.AddWithValue("@Organization", Name);
//                        comm.Parameters.AddWithValue("@Block", 1);
//                        string StringommandText = "INSERT INTO getsoftware_Links(email , link , Organization, Block) VALUES ( @email , @link , @Organization, @Block)";

//                        comm.CommandText = StringommandText;

//                        try
//                        {
//                            comm.ExecuteNonQuery();
//                        }
//                        catch (Exception ex)
//                        {
//                            Console.WriteLine(ex.ToString());

//                        }

//                        // string thea_filename  ="ftp://" + ftphost1 + "/httpdocs/files/Videos/" + gstring + ".mp4";

//                        try
//                        {
//                            comm.Dispose();

//                        }
//                        catch (Exception ex)
//                        {
//                            Console.WriteLine(ex.ToString());

//                        }

//                        //   stream.Close();

//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.ToString());

//            }
//            return;

//            ///
//            //   string newpath = "https://getsoftwareandsupport.com/Uploads/" + gstring;
//            string newpath = "~/Uploads/" + gstring;
//            //Send File details in a JSON Response.
//            string json = new JavaScriptSerializer().Serialize(
//                new
//                {
//                    name = fileName
//                });
//            context.Response.StatusCode = (int)HttpStatusCode.OK;
//            context.Response.ContentType = "video/mp4";
//            context.Response.Write(json);
//            string saythis = "Your video was uploaded to" + newpath;
//            //string script = "alert(\"Hello!\");";
//            //System.Windows.Forms.MessageBox.Show(saythis);
//            App_Vars.link_to_video = newpath;
//            context.Response.End();


//        }
//        //var formData = context.Request.Form; // Get the form object from the current HTTP request.

//        //foreach (var formVariable in formData)
//        //{
//        //    var value = formData[formVariable.ToString()].ToString();
//        //}
//    }

//    //
//    //      context.Request.Form["SearchKey"].ToString();
//}
//}

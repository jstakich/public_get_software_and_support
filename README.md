# public_get_software_and_support
Record mp4 video using Javascript . Upload it and the link using Javascript/C#/ASP.net. Store the links in a MySQL Database.

This is a C#.net Web Form Application that records video in an mp4 format using Javascript and uploads it. It stores the links in a MySQL database 
and displays the results in a datagridview.

Helpful information.
https://developer.mozilla.org/en-US/docs/Web/API/MediaStream_Recording_API
https://developers.google.com/web/updates/2016/01/mediarecorder
https://github.com/mdn/content/blob/main/files/en-us/web/api/mediarecorder/mediarecorder/index.md



1. Add all needed references in Nuget package manager.

2. Set your connection strings to the MySQL database in App_Vars.cs

3. After publishing the app to your server , the ApplicationPool account must have write
access to the 'MyRecordedVideos' folder. This should be ok while debugging on local in Visual Studio.

4. You can find the tables and indexes for this app in the 'MySQL_Database_Info_Setup. folder in a text file.

5. 'App.html' is loaded in 'Record_MP4.aspx' . The javascript logic is called from here

6. a. In the 'Record_MP4.aspx' file , You will have to change this logic in Record_MP4.aspx to match your setup and to run locally.

   b. if (folderPath.ToString().ToLower().Contains(@"c:\"))
            {

                  ////////////////////////Your local instance in Visual Studio
                    textbox_Url.Value = "https://localhost:44333/Video_Uploader.ashx";
                 
                }
            else
                {

                   ////////////////////////Your published server
                   textbox_Url.Value = "https://getsoftwareandsupport.com/Video_Uploader.ashx";
                   
                }

            
        }

c. You can see that the above logic will post in the main.html file in the PostBlob function  

d. const url = textboxurlvalue + "?name=" + textboxvalue;
    Http.open("Post", url);      
    Http.send(formData)

e. That is then sent to  Video_Uploader.ashx and the link is written to a MYSQL database and the file is uploaded.


7. You won't be able to send emails until you set the variables for your server. You will need to put the  mailSettings  section
in your web config. The entire web config can be found in the file 'Backup_prod_web_config.txt
  <system.net>
    <mailSettings>
     <smtp from="jeremystakich@getsoftwareandsupport.com">
      <network host="relay-hosting.secureserver.net" port="25" />
        <!--	<network host="smtp.gmail.com" port="587" /> -->
     </smtp>
     </mailSettings>
  </system.net>



   

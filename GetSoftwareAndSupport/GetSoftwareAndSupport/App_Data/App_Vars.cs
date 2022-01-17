using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for App_Vars
/// </summary>
 public class App_Vars
{

    public static string link_to_video = "";

    public static string link_to_videoq = "";
}

public class Connection_Strings
{
    public string prod_conn_string = "Server=127.0.0.0;Port=3306;Database=database;Uid=username;Pwd=password; ";
    public string PCIDATA_prod_conn_string = "Server=127.0.0.0;Port=3306;Database=database;Uid=username;Pwd=password; ";





}


public class Support_Information_main
{
    
    

}



public class Support_Information
{


    public Nullable<int> application_id { get; set; }
    public Nullable<int> vendor_id { get; set; }
    public Nullable<DateTime> contract_start_date { get; set; }
    public Nullable<DateTime> contract_end_date { get; set; }
    public Nullable<int> purchase_ave_id { get; set; }
    public Nullable<decimal> initial_purchase_price { get; set; }
    public Nullable<decimal> renewal_cost { get; set; }

}
public class App_Information
{

    public string application_name_string { get; set; }
    public string description_string { get; set; }
    public string dr_priority_level_id_string { get; set; }
    public string data_classification_id_string { get; set; }
    public string current_installed_version_string { get; set; }
    public string lastest_available_version_string { get; set; }
    public string hosting_type_string { get; set; }
    public string diagram_link_string { get; set; }
    public string status_string { get; set; }
    public Nullable<int> dr_priority_level_id_int { get; set; }
    public Nullable<int> data_classification_id_int { get; set; }
    public Nullable<int> hosting_type_int { get; set; }
    public Nullable<int> status_int { get; set; }

   


}
public class Insert_Info
    {
    public int count { get; set; }
    public int ID_Inserted { get; set; }
   
   
}
public class License_Info
{

     public string License_Key { get; set; }
    public string Description { get; set; }
   
}

public class Contact_Info
{

    public Nullable<int> Contact_ID { get; set; }
    public string Contact_ID_String { get; set; }
    public string Contact_Name { get; set; }
    public Nullable<int> Role_ID { get; set; }
    public string Role_ID_String { get; set; }
    public string Role_Name { get; set; }
    public string cell_phone { get; set; }
    public string office_phone_ext { get; set; }
    public string office_phone { get; set; }
    public string email { get; set; }
    public string last_name { get; set; }
    public string middle_name { get; set; }
    public string first_name { get; set; }

}
public class AD_Groups
{

    public string SID { get; set; }
    public string Group_Name { get; set; }
    public string Permission { get; set; }

    public Nullable<int> app_user_relation { get; set; }

}


public class Comment
{

    public string c_lbl_Name { get; set; }
    public string c_txt_Name { get; set; }
    public string c_txt_Email { get; set; } 
    public string c_txt_Comment { get; set; }
 
    public string c_txt_ts { get; set; } 
    public Nullable<int> app_user_relation { get; set; }

}
public class Department_Usage
{
    public Nullable<int>Department_ID { get; set; }
    public string Department_ID_String{ get; set; }
    public string Department_Name { get; set; } 
    public Nullable<int> Usage_ID { get; set; }
    public string Usage_ID_String { get; set; }
    public string Usage_Name { get; set; }
    public string department_code { get; set; }
}

public class User_Info
{

    public string UserID { get; set; }
    public string UserName { get; set; }
    public string AD_Account { get; set; }
    public Nullable<int> Department_ID { get; set; } 
    public string Department_ID_String { get; set; }
    public string Department_Name { get; set; } 
    public string Permissions { get; set; }
    public Nullable<int> app_user_relation { get; set; }
}


public class Payload
{
    [Newtonsoft.Json.JsonProperty("channel")]
    public string Channel { get; set; }

    [Newtonsoft.Json.JsonProperty("username")]
    public string Username { get; set; }

    [Newtonsoft.Json.JsonProperty("text")]
    public string Text { get; set; }
}
public class SlackClient
{
    private readonly Uri _uri;
    private readonly System.Text.Encoding _encoding = new System.Text.UTF8Encoding();

    public SlackClient(string urlWithAccessToken)
    {
        _uri = new Uri(urlWithAccessToken);
    }

    //Post a message using simple strings
    public void PostMessage(string text, string username = null, string channel = null)
    {
        Payload payload = new Payload()
        {
            Channel = channel,
            Username = username,
            Text = text
        };

        PostMessage(payload);
    }

    //Post a message using a Payload object
    public void PostMessage(Payload payload)
    {
        string payloadJson = Newtonsoft.Json.JsonConvert.SerializeObject(payload);

        using (System.Net.WebClient client = new System.Net.WebClient())
        {
            System.Collections.Specialized.NameValueCollection data = new System.Collections.Specialized.NameValueCollection();
            data["payload"] = payloadJson;

            var response = client.UploadValues(_uri, "POST", data);

            //The response text is usually "ok"
            string responseText = _encoding.GetString(response);
        }
    }
}


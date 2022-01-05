 
 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GetSoftwareAndSupport.Account.Login" %>


 
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
   
    <asp:UpdatePanel ID="updPnl" runat="server"    UpdateMode="Conditional" 
                ChildrenAsTriggers="true"   >

<ContentTemplate>


 

      <div>
      <nav class="navbar navbar-default navbar-fixed-top" id="RedMenu" style="background-color:lightgray">  
        <div class="container-fluid">  
            <!--Navbar Header Start Here-->  
            <div class="navbar-header">  
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#MainNavBar"   
                   style="background-color:#000">  
                    <span class="icon-bar" style="background-color:#ffffff"></span>  
                    <span class="icon-bar" style="background-color:#ffffff"></span>  
                    <span class="icon-bar" style="background-color:#ffffff"></span>  
                </button>  
                <a class="navbar-brand" style="color: #6c757d" href="/Default">GetSoftwareAndSupport.com</a>  
                
            </div>  
            <!--Navbar Header End Here-->  
            <!--Menu Start Here-->  
            <div class="collapse navbar-collapse" id="MainNavBar">  
                <ul class="nav navbar-nav navbar-right">  
            
 

 
                
                   <%--   <li> 
                
                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_logout" 
                                 title="Click to logout." 
                                Text="<i class='fa fa-sign-out'></i> &nbsp;Logout" 
                                ValidationGroup="edtasfdff" 
                                OnClick="Logout_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
        </li>--%>


                 
                      


                      
                     
               <%--     <%     
   try
            {
                if (Session["Logged_in"] != null)
                {
                    string str_read_login_var = Convert.ToString(Session["Logged_in"]);

                    //////////////////////////////// If User is logged in 
                    if (str_read_login_var == "True")
                    {
%>--%>
                     <%-- <li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_login" 
                                 title="Click to login." 
                                Text="<i class='fa fa-sign-in'></i>&nbsp;Login" 
                                ValidationGroup="edtasfd" 
                                OnClick="Login_Click" 
                                
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Visible="False" />
                          
                          
                           </li>--%>
  <%--<li> 
                
                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_logout" 
                                 title="Click to logout." 
                                Text="<i class='fa fa-sign-out'></i> &nbsp;Logout" 
                                ValidationGroup="edtasfdff" 
                                OnClick="Logout_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"   Visible="True"/>
        </li>--%>

                 
                     

                       
                    <%--<li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton_EditAccount" 
                                 title="Click to edit account." 
                                Text="<i class='fa fa-address-card'></i> &nbsp;Edit Account" 
                                ValidationGroup="edtffffa" 
                                OnClick="Edit_Account_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Visible="True" />
                          
                          
                           </li>--%>

                  

<%--                    <%
 }
                }
                else
                {
                    //////////////////////////////// If User is NOT logged in 
                   %>--%>

  
                    <%--  <li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton1" 
                                 title="Click to login." 
                                Text="<i class='fa fa-sign-in'></i>&nbsp;Login" 
                                ValidationGroup="edtasfd" 
                                OnClick="Login_Click" 
                                
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Visible="True" />
                          
                          
                           </li>--%>
                    
                    
                   <%-- <li> 
                
                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_logoutsss" 
                                type="submit"  
                                title="Click to logout." 
                                Text="<i class='fa fa-sign-out'></i> &nbsp;Logout" 
                                ValidationGroup="edtasfdff" 
                                OnClick="Logout_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"   Visible="False"/>
        </li>--%>

                 
                     

                       
                   <%-- <li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton_EditAccountss" 
                                 title="Click to edit account." 
                                Text="<i class='fa fa-address-card'></i> &nbsp;Edit Account" 
                                ValidationGroup="edtffffa" 
                                OnClick="Edit_Account_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Visible="False" />
                          
                          
                           </li>--%>

                 <%--   <%
                }

            }
            catch (Exception ex)
            {
                //////////////////////////////// If User is NOT logged in 
                 %>--%>


                      <%--<li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton2" 
                                 title="Click to login." 
                                Text="<i class='fa fa-sign-in'></i>&nbsp;Login" 
                                ValidationGroup="edtasfd" 
                                OnClick="Login_Click" 
                                
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Visible="True" />
                          
                          
                           </li>--%>

  <%--<li> 
                
                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_logoutsssaaa" 
                                 title="Click to logout." 
                                Text="<i class='fa fa-sign-out'></i> &nbsp;Logout" 
                                ValidationGroup="edtasfdff" 
                                OnClick="Logout_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"   Visible="False"/>
        </li>--%>

                 
                     

                       
                  <%--  <li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton_EditAccountssaaa" 
                                 title="Click to edit account." 
                                Text="<i class='fa fa-address-card'></i> &nbsp;Edit Account" 
                                ValidationGroup="edtffffa" 
                                OnClick="Edit_Account_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Visible="False" />
                          
                          
                           </li>--%>

                 <%--   <%
            }
 %>--%>












                   

                      <li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton_loginbutton" 
                                type="submit" 
                                 title="Click to login." 
                                Text="<i class='fa fa-sign-in'></i>&nbsp;Login" 
                                ValidationGroup="edtasfd" 
                                OnClick="Login_Click" 
                                
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"   />
                          
                          
                           </li>
                    
                    
                    <li> 
                
                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton_logoutbutton" 
                                type="submit"  
                                title="Click to logout." 
                                Text="<i class='fa fa-sign-out'></i> &nbsp;Logout" 
                                ValidationGroup="edtasfdff" 
                                OnClick="Logout_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"    />
        </li>

                 
                     

                       
                    <li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton_editaccountbutton" 
                                type="submit" 
                                 title="Click to edit account." 
                                Text="<i class='fa fa-address-card'></i> &nbsp;Edit Account" 
                                ValidationGroup="edtffffa" 
                                OnClick="Edit_Account_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"  />
                          
                          
                           </li>

                      

                      <li>  


                           <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="Button2sss" 
                                type="submit" 
                                 title="Click to go to the home page." 
                                Text="<i class='fa fa-home'></i> &nbsp;Home" 
                                ValidationGroup="edtffffa" 
                                OnClick="Default_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"  />

                            
                          
                          
                           </li>

                      <li>


                           <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btnabout1" 
                                type="submit" 
                                 title="Click to go to the about us page." 
                                Text="<i class='fa fa-info'></i> &nbsp;About Us" 
                                ValidationGroup="edtffffa" 
                                OnClick="About_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"  />

                    
</li>
                     <%--<li>  <i class="fa fa-id-card" aria-hidden="true"> 
                         <button runat="server" id="about_button" t  class="btn btn-mini" title="Search">
    <i class="fa fa-id-card" aria-hidden="true"></i> About Us
</button>
                          
                         </li>--%>

 <%--<button runat="server" id="btnRun" class="btn btn-mini" title="Search">
    <i class="icon-camera-retro"></i> Search
</button>--%>

    <li> 

         <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="Button1a" 
                                type="submit" 
                                 title="Click to go to the contact us page." 
                                Text="<i class='fa fa-id-card'></i> &nbsp;Contact Us" 
                                ValidationGroup="edtffffa" 
                                OnClick="ContactUS_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"  />

        
        
       </li>


                   
                </ul>  
            </div>  
            <!--Menu End Here-->  
        </div>  
    </nav>
            </div>

    <form   enctype="multipart/form-data" method="post">
      <header>
        <script type="text/javascript">
            function getback() { window.history.forward(1); }
            setTimeout("getback()", 0);
            window.onload = function () { null };
        </script>
    </header>
 

       <asp:Panel ID="Panel2" runat="server" CssClass="Panel_Content_my_main text-secondary"  Visible="true"        > 
          

<asp:Panel ID="Panel_Main" runat="server" CssClass="Panel_Content_with_Textboxes text-secondary" Visible="true"        > 



 
 
   
        
       
      
         
              <h2>    <asp:Label ID="Label1" runat="server" BorderStyle="None"   Text="Welcome to Get Software And Support.com"></asp:Label> </h2>
                <h4>   <H1><i class="fa fa-laptop" aria-hidden="true"></i> <i class="fa fa-windows"  aria-hidden="true"></i> <i class="fa fa-google"  aria-hidden="true"></i></H1>   <asp:Label ID="Label2" runat="server" BorderStyle="None"   Text="Custom .Net Development & Google Scripting"></asp:Label> 
                    <h4></h4>
                    <h6>
                        <asp:Label ID="Label3" runat="server" BorderStyle="None" Text="Building better apps for your business"></asp:Label>
                    </h6>
              </h4>
              
 </asp:Panel>            
   

   
     
 <%-- Instructions--%>
<asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_with_Textboxes " Visible="true"  > 
    

    

    
   <%-- Start Login Form--%>
     <asp:Panel ID="Panel_Login" runat="server" CssClass="Panel_Content_with_Textboxes " Visible="true"  > 
    <div style='  overflow-y: scroll; overflow-x: scroll;'>  
         <div  class="col-form text-left">  
       <h4>  Please login.</h4>
        </div>


            <div class="container py-5">
    <div class="row">
        <div class="col-md-10 mx-auto">
            <%--<form>--%>
                <div class="form-group row">
                    <div class="col-sm-6">
                          <i class="fa fa-user" aria-hidden="true">

                                        <label for="inputFirstname">Email :</label>
                
                      <asp:TextBox ID="txt_username" runat="server" Class="form-control" Text=""  maxlength="40"   placeholder="" autocomplete="put_this_at_a_random_string"   type="text"        AutoCompleteType="Disabled"    ></asp:TextBox>
</i>                        </div>
                    <div class="col-sm-6">
                         <i class="fa fa-key" aria-hidden="true">
                        <label for="inputLastname">Password :</label>
                      <asp:TextBox ID="txt_password" runat="server"    autocomplete="put_this_at_a_random_string" placeholder="" type="text"  maxlength="40"  Class="form-control" OnTextChanged="log_in_user"  AutoCompleteType="Disabled" TextMode="Password" AutoPostBack="True"    ></asp:TextBox>
                    </i>
                             </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                          <asp:LinkButton runat="server" Name="Button1"  ID="LinkButton1" 
        type="submit" class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
          OnClick="LogIn"  ToolTip="Click to login."   >
        <i class="fa fa-sign-in" aria-hidden="true"></i>&nbsp;Login
      </asp:LinkButton>
                    </div>


 
                   <%-- <div class="col-sm-6">
                           <label for="inputLastname"> </label>
                          <label for="inputLastname"> </label>
                    </div>--%>
                </div>
               <%-- <div class="form-group row">
                    <div class="col-sm-6">
                           </div>
                    <div class="col-sm-3">
                              <label for="inputLastname"> </label>
                          <label for="inputLastname"> </label>
                    </div>
                    <div class="col-sm-3">
                             <label for="inputLastname"> </label>
                          <label for="inputLastname"> </label>
                    </div>
                </div>--%>
               <%-- <div class="form-group row">
                    <div class="col-sm-6">
                           <label for="inputLastname"> </label>
                          <label for="inputLastname"> </label>
                    </div>
                    <div class="col-sm-6">
                            <label for="inputLastname"> </label>
                          <label for="inputLastname"> </label>
                    </div>
                </div>--%>
             
            <%--</form>--%>
        </div>
    </div>
</div>
       

         

           


           


</div>


         
 
        
  <%--</div>--%>

         

         
 
 
   
         
         <%-- End Login Form--%>
       </asp:Panel>  


     
 
  



        <div class="col-12">
          <p class="text-danger">
                     <asp:Label ID="lbl_message" runat="server" Class="col-1 col-form-label"   Text=""></asp:Label> 
                 <label for="inputDatblank58" Class="col-1 col-form-label"></label>
                  </p>
  </div>
        <%--</form>--%>

     <asp:Panel ID="Panel4" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px"  > 
   
      <div  class="col-form text-left">  
      <h5> <i class="fa fa-key" aria-hidden="true"></i>   <asp:CheckBox ID="cboxforgotpassword" runat="server" AutoPostBack="True" OnCheckedChanged="cboxforgotpassword_CheckedChanged" Text="   Forgot Password ?" />&nbsp;&nbsp;</h5>
</div>
    <asp:Panel ID="Panel4_forgotpassword" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px" Visible="False"  > 
         <h4>If you forgot your password we can send you a temporary password to your email if you have previously registered.</h4>
                      <h4><strong>
                          <p class="text-danger">
                              Note: It could take up to 10 minutes for your to recieve your password via email.</p></strong>
                           <h4></h4>
                          <div style="overflow-y: scroll; overflow-x: scroll;">
                              
                              
                              




   <div class="container py-5">
    <div class="row">
        <div class="col-md-10 mx-auto">
            <%--<form>--%>
                <div class="form-group row">
                    <div class="col-sm-6">
                         <i class="fa fa-user">
                        <label for="inputFirstname">Email  :</label>
                                 <asp:TextBox ID="txt_forgotten_email" runat="server" OnTextChanged="txt_forgotten_email_TextChanged"></asp:TextBox>
                  </i>
                             </div>
                    <div class="col-sm-6">
                       

                          <asp:LinkButton runat="server" Name="LinkButton3aaa"  ID="LinkButton3aaa" 
        type="submit" class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
          OnClick="forgot_Password_Click"  ToolTip="Click to have a temporary password sent to your email."   >
        <i class="fa fa-key" aria-hidden="true"></i>&nbsp;Send
      </asp:LinkButton>

                    </div>
                </div>
               <%-- <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputAddressLine1"> </label>
                      <label for="inputAddressLine1"> </label>
                    </div>
                    <div class="col-sm-6">
                        <label for="inputAddressLine1"> </label>
                      <label for="inputAddressLine1"> </label>
                    </div>
                </div>--%>
            <%--    <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputAddressLine1"> </label>
                      <label for="inputAddressLine1"> </label>
                    </div>
                    <div class="col-sm-3">
                       <label for="inputAddressLine1"> </label>
                      <label for="inputAddressLine1"> </label>
                    </div>
                    <div class="col-sm-3">
                       <label for="inputAddressLine1"> </label>
                      <label for="inputAddressLine1"> </label>
                    </div>
                </div>--%>
             <%--   <div class="form-group row">
                    <div class="col-sm-6">
                        <label for="inputAddressLine1"> </label>
                      <label for="inputAddressLine1"> </label>
                    </div>
                    <div class="col-sm-6">
                      <label for="inputAddressLine1"> </label>
                      <label for="inputAddressLine1"> </label>
                    </div>
                </div>--%>
                   
  
            <%--</form>--%>
        </div>
    </div>
</div>



 

                                  
                              
                             
</div>
                              
                            
                              
                              
                            
                         
                          <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           <h4></h4>
                           </h4>

           
             
            
          
               
                
       
 </asp:Panel>
       </asp:Panel>    
     <asp:Panel ID="Panel3" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px"  > 
       <div  class="col-form text-left">  
       <h5> <i class="fa fa-address-card" aria-hidden="true"></i>  <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="   Click to Register." />&nbsp;&nbsp;</h5>
        </div>
          <asp:Panel ID="Panel_registration" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px" Visible="False"  > 
       <h4>Please fill out the registration form.</h4>
                       
              
              <div style='  overflow-y: scroll; overflow-x: scroll;'>  




                     <div class="container py-5">
    <div class="row">
        <div class="col-md-10 mx-auto">
            <%--<form>--%>
                <div class="form-group row">
                    <div class="col-sm-6">
                        <i class="fa fa-address-book">
                        <label for="inputFirstname">First Name  :</label>
                       <asp:TextBox ID="txt_firstname" Class="form-control" runat="server"></asp:TextBox>
                                </i>
                    </div>
                    <div class="col-sm-6">
                         <i class="fa fa-address-book">
                        <label for="inputLastname">Middle Name  :</label>
                      <asp:TextBox ID="txt_middlename" Class="form-control" runat="server"></asp:TextBox> 
                              </i>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                         <i class="fa fa-address-book">
                        <label for="inputAddressLine1">Last Name  :</label>
                      <asp:TextBox ID="txt_lastname" Class="form-control" runat="server"></asp:TextBox> 
                        </i>

                    </div>
                    <div class="col-sm-6">
                          <i class="fa fa-address-book">
                        <label for="inputAddressLine2">Phone Number  :</label>
                      <asp:TextBox ID="txt_phone_number" Class="form-control" runat="server" TextMode="Number"></asp:TextBox> 
                               </i>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                             <i class="fa fa-question">
                        <label for="inputCity">Security Question  :</label>
                        <asp:TextBox ID="txt_Security_Question1" Class="form-control" runat="server" TextMode="MultiLine" Height="185px" CssClass="textarea"></asp:TextBox>
                   </i>
                                 </div>
                    <div class="col-sm-3">
                         <i class="fa fa-reply">
                        <label for="inputState">Security Answer  :</label>
                      <asp:TextBox ID="txt_Security_Answer" Class="form-control" runat="server" TextMode="Password"></asp:TextBox>  
                   </i>
                             </div>
                    <div class="col-sm-3">
                           <i class="fa fa-user">
                        <label for="inputPostalCode">Email  :</label>
                     <asp:TextBox ID="txt_reg_email" runat="server"></asp:TextBox> 
                                 </i>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                         <label for="inputPostalCode"></label> 
                           <label for="inputPostalCode"></label> 
                    </div>
                    <div class="col-sm-6">
                           <label for="inputPostalCode"></label> 
                           <label for="inputPostalCode"></label> 
                    </div>
                </div>

             <%--<div class="col-6 col-md-4">--%>


      <%--<asp:FileUpload ID="FileUpload1" runat="server" />--%>
			 
			<%--<asp:Button runat="server" id="Button1" text="Upload" onclick="UploadButton_Click" />--%>
			 <asp:Image ID="Image5" Width="50" Height="50" runat="server" />
            
            <div class="custom-file" runat="server">
   <strong> <i class="fa fa-image" aria-hidden="true"> <input type="file" runat="server" class="custom-file-input" id="customFile"></i> </strong>
   <strong> <i class="fa fa-image" aria-hidden="true">  <label class="custom-file-label" for="customFile">Choose Profile Picture</label></i> </strong>
  </div>
     <div>

         <%--<strong> <i class="fa fa-image" aria-hidden="true"><label for="inputPostalCode"></i>&nbsp;Upload a profile image</label> </strong>--%>  
               <%--  <asp:FileUpload ID="FileUpload1" runat="server" />--%>
                 <%--<asp:FileUpload ID="FileUpload1" class="longbutton fa" runat="server" />--%> 
       <%-- <asp:Button ID="btnAsyncUpload" runat="server" Text="Async_Upload" OnClick = "UploadButton_Click" />--%>
          <p class="text-danger">
           <strong>       <asp:Label runat="server" id="lbl_upload_Status"  text="Profile Picture Upload Status: " /></strong> 
              </p>
       <%-- <asp:Button ID="btnUpload" runat="server" Text="Upload"  OnClick = "Upload_File" /> --%>
 
         <br />
                   <asp:LinkButton runat="server" Name="btnUpload"  ID="btnUpload" 
          class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
          OnClick="Upload_File"  ToolTip="Click to Upload file." Visible="False"   >
        <i class="fa fa-image" aria-hidden="true"></i>&nbsp;Upload
      </asp:LinkButton>
<hr />
 </div>

  </div>

                <asp:LinkButton runat="server" Name="Button1register"  ID="LinkButton3ssss" 
        type="submit" class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
          OnClick="register_Click"  ToolTip="Click to register."   >
        <i class="fa fa-id-card" aria-hidden="true"></i>&nbsp;Register
      </asp:LinkButton>

            
            <%--</form>--%>
        </div>
    </div>
</div>


                  

            













            
        </div>  
       </asp:Panel>
     </asp:Panel>
    

        <asp:Panel ID="Panel_Change_Password1" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px" Visible="False"  > 
       <div  class="col-form text-left">  
       <h5> <i class="fa fa-key" aria-hidden="true"></i> &nbsp;&nbsp; New Password&nbsp; :</h5>
        </div>
          <asp:Panel ID="Panel_Change_Password" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px"  > 
        <div style='  overflow-y: scroll; overflow-x: scroll;'>  
            <table class="auto-style1">  
                 

                 

                 

                

                     <tr>  
                    <td>Please set a new password now.</td>  
                       
                </tr>  
              
               

                
                
                <tr>  
                    <td>Password&nbsp; :</td>  
                     <td> <asp:TextBox ID="txt_passwordmysql" runat="server" TextMode="Password"></asp:TextBox></td>  
                </tr>  
              
                
                <tr>  
                    <td>Confirm Password&nbsp; :</td>  
                    <td>  
                        <asp:TextBox ID="txt_confirm_Password" runat="server" TextMode="Password"></asp:TextBox>  
                    </td>  
                </tr>  
            
          
               
                <tr>  
                    <td>  
                        <asp:Button ID="btn_new_password"  ToolTip="Change Password" class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa"  runat="server" Text="Change Password" OnClick="ChangePassword_Click" />  
                    </td>  
                </tr>  
            </table>  
        </div>  
       </asp:Panel>
     </asp:Panel>

               <%-- Start Register Form--%>
        <asp:Panel ID="Panel_Register" runat="server" CssClass="Panel_Content_with_Textboxes " Visible="false"  > 
             
              <%-- Start row --%>
            <div class="row">

  <div class="col-6 col-md-4">
      
         <label for="inputAddress" class="form-label">Address</label>
  
         <asp:TextBox ID="txt_first_name" runat="server"    autocomplete="put_this_at_a_random_string" placeholder="" type="text"  maxlength="100"  Class="form-control" AutoCompleteType="Disabled" TextMode="SingleLine"   ></asp:TextBox>

  </div>

  <div class="col-6 col-md-4">
 
          <label for="inputAddress2" class="form-label">Address 2</label>
    <input type="text" class="form-control" id="inputAddress2eedd" placeholder="Apartment, studio, or floor">
 

  </div>

  <div class="col-6 col-md-4">

       <label for="inputAddress2" class="form-label">Address 2</label>
    <input type="text" class="form-control" id="inputAddress2ee" placeholder="Apartment, studio, or floor">

  </div>

</div>
<%--End row--%>


           <%-- Start row --%>
            <div class="row">

  <div class="col-6 col-md-4">
      
         <label for="inputAddress2" class="form-label">Address 2</label>
    <input type="text" class="form-control" id="inputAddress222" placeholder="Apartment, studio, or floor">

  </div>

  <div class="col-6 col-md-4">
      
         <label for="inputAddress2" class="form-label">Address 2</label>
    <input type="text" class="form-control" id="inputAddress22" placeholder="Apartment, studio, or floor">

  </div>

<%--  <div class="col-6 col-md-4">


      <%--<asp:FileUpload ID="FileUpload1" runat="server" />--%>
			 
		<%--	<asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
			<asp:Label runat="server" id="StatusLabel" text="Upload status: " />--%>
    

 
<hr />


  </div>--%>

                <div class="col-6 col-md-4">
               
 

 </div>


                 <div class="col-6 col-md-4">

</div> 

            <div class="col-6 col-md-4">

</div> 


                            <div class="col-6 col-md-4">
 <asp:LinkButton runat="server" Name="Button1"  ID="LinkButton2" 
        type="submit" class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
          OnClick="registernowwww"  ToolTip="Click to Register."   >
        <i class="fa fa-sign-in" aria-hidden="true"></i>&nbsp;Register
      </asp:LinkButton>
</div> 


            </div>
<%--End row--%>
 </asp:Panel> 
           <%-- End Register Form--%>
    
            <%-- Content 1--%>  
 
                                








 



        <asp:Panel ID="Register_Edit" ScrollBars="Auto" runat="server" CssClass="Panel_Content_with_Textboxes " Visible="False" > 


 
   
           <asp:GridView ID="gvImages" 
                
              
               runat="server" 

            RowStyle-Wrap="false" 
            HeaderStyle-CssClass="gridview_csss"
            HeaderStyle-BackColor="#007bff" 
            HeaderStyle-ForeColor="White"
            RowStyle-BackColor="#FFFFFF" 
            AlternatingRowStyle-BackColor="White"  
            PageSize="8" CssClass="Grid"   
            PagerStyle-CssClass="pgr"  
            AlternatingRowStyle-CssClass="alt" 
            AllowPaging="true"  
            AutoGenerateColumns="false"  
            OnPageIndexChanging="PageIndexChanging"  
            HeaderStyle-HorizontalAlign="Right"
           ItemStyle-HorizontalAlign="Right" 
           CellPadding="10"    
           OnRowCancelingEdit="gvImages_RowCancelingEdit"   
            OnRowEditing="gvImages_RowEditing"
            OnRowUpdating="gvImages_RowUpdating"
            OnRowDeleting="gvImages_RowDeleting"
             OnRowDataBound="gvImagesOnRowDataBound"   
                 >  
            <Columns>  

          
              
            
       
                <asp:TemplateField HeaderText="Edit Options">  
                    <ItemTemplate>  
                             <asp:Image ID="Image1" runat="server" Height="80" Width="80" />
                        <ItemTemplate>
       
            </ItemTemplate>
                                 <asp:LinkButton runat="server" Name="btn_Edit11"  ID="btn_Edit11" 

type="submit"
                          class="btn btn-primary custom_smaller_middle_color_blue_same_color_dropdown_button fa" 
                          CommandName="Edit" 
                          ToolTip="Click to edit."    >
                          <i class="fa fa-edit" aria-hidden="true"></i>&nbsp;Edit
                           </asp:LinkButton>

                    </ItemTemplate>  

                    
                    <EditItemTemplate>  
                  
               
                            <asp:LinkButton runat="server" Name="btn_update1"  ID="btn_update1" 
                          type="submit"
                          class="btn btn-success custom_smaller_button fa" 
                          CommandName="Update"
                          OnClientClick="return confirm_update();" 
                          ToolTip="Update item in database."    >
                          <i class="fa fa-save" aria-hidden="true"></i>&nbsp;Update
                           </asp:LinkButton>
                        
                       
                       
                        
                         <asp:LinkButton runat="server" Name="btn1_delet1"  ID="btn1_delet1" 
                          type="submit"
                          class="btn btn-danger custom_smaller_button fa" 
                          CommandName="Delete"
                          OnClientClick="return confirm_delete();" 
                          ToolTip="Delete item in database."    >
                          <i class="fa fa-trash" aria-hidden="true"></i>&nbsp;Delete
                           </asp:LinkButton>
                        
                         

                          <asp:LinkButton runat="server" Name="btn_cancel1"  ID="btn_cancel1" 
                          type="submit"
                          class="btn btn-secondary custom_smaller_button fa" 
                          CommandName="Cancel" 
                          ToolTip="Click to cancel."    >
                          <i class="fa fa-window-close" aria-hidden="true"></i>&nbsp;Cancel
                           </asp:LinkButton>

                        
                    </EditItemTemplate>  
                </asp:TemplateField> 
                <asp:TemplateField Visible="false" HeaderText="ID">  
                    <ItemTemplate>  
    
                    </ItemTemplate>  
             
                    
                       </asp:TemplateField>    
                     

               

                  <asp:TemplateField HeaderText="Id">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Id" Class="form-control text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Enabled="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Id") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Id" Class="form-control text-dark"    style="padding-left:5px; padding-right:5px;" runat="server" Enabled="false" Text='<%#Eval("Id") %>'   BackColor="whitesmoke" BorderColor="Transparent"></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   

                  <asp:TemplateField HeaderText="First_Name" Visible="false">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_First_Name" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server"  BackColor="Transparent" Visible="false" BorderColor="Transparent" Text='<%#Eval("First_Name") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_First_Name" Class="form-control text-dark"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("First_Name") %>'  Visible="false" BackColor="whitesmoke" BorderColor="Transparent"></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   


                 <asp:TemplateField HeaderText="Middle Name" >  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Middle_Name" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server"  Enabled="false" BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Middle_Name") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Middle_Name" Class="form-control text-dark"    style="padding-left:5px; padding-right:5px;" runat="server" Enabled="false" Text='<%#Eval("Middle_Name") %>'   BackColor="whitesmoke" BorderColor="Transparent"></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>

                  <asp:TemplateField HeaderText="Last Name">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Last_Name" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Last_Name") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Last_Name" Class="form-control text-dark"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("Last_Name") %>'   BackColor="Transparent" BorderColor="Transparent"></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>
                   
                   
                 
             

                 <asp:TemplateField HeaderText="Password" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_Password" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Password") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Password" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("Password") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   
                   



                 <asp:TemplateField HeaderText="Email" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_Email" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Email") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Email" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("Email") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   


                 <asp:TemplateField HeaderText="Phone" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_Phone" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Phone") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Phone" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("Phone") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   



                 <asp:TemplateField HeaderText="Approved" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_Approved" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Approved") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Approved" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("Approved") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   


                  <asp:TemplateField HeaderText="The_Image" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_The_Image" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("The_Image") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_The_Image" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("The_Image") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  

          
     
              
          <asp:TemplateField HeaderText="The_Imageqq" Visible="true"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_The_Imageqq" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("The_Image") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Image ID="Image2" runat="server" Height="80" Width="80" />
                    </EditItemTemplate>  
                </asp:TemplateField>  
                 


                 <asp:TemplateField HeaderText="ts" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_ts" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("ts") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_ts" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("ts") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   


                 <asp:TemplateField HeaderText="dt" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_dt" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("dt") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_dt" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("dt") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   


                      <asp:TemplateField HeaderText="Phone" Visible="false"   >  
                    <ItemTemplate >  
                        <asp:Label ID="lbl_Phonea" Class="form-control  text-dark"  style="padding-left:5px; padding-right:5px;" runat="server" Visible="false"  BackColor="Transparent" BorderColor="Transparent" Text='<%#Eval("Phone") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Phonea" Class="form-control text-dark input-lg" aria-label="Large"    style="padding-left:5px; padding-right:5px;" runat="server" Text='<%#Eval("Phone") %>' Visible="false"  BackColor="Transparent" BorderColor="Transparent" ></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>   
                

            </Columns>  
               
                













    
         
  
</asp:GridView>

                   



 </asp:Panel> 



                                       
       </asp:Panel>                   

                     
 
 </asp:Panel> 
    
 
 

 
         
        </form> 
</ContentTemplate>
      <Triggers>
        
 <%--<asp:AsyncPostBackTrigger ControlID = "btnAsyncUpload" EventName = "Click" />--%>
        <asp:PostBackTrigger ControlID = "btnUpload" />    
             <asp:PostBackTrigger ControlID = "LinkButton3ssss" />  
         <%--   <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click"/>  --%>
            <asp:AsyncPostBackTrigger ControlID="LinkButton1" EventName="Click"/>    
          <asp:AsyncPostBackTrigger ControlID="CheckBox1" EventName="CheckedChanged"/>  
               
    </Triggers>
   
    
</asp:UpdatePanel>  
</asp:Content>


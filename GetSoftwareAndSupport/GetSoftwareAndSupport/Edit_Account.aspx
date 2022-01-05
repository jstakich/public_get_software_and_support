<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit_Account.aspx.cs" Inherits="GetSoftwareAndSupport.Edit_Accout" %>

 
      
    
 

 
    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
   
        <asp:UpdatePanel ID="updPnl" runat="server"    UpdateMode="Conditional" 
                ChildrenAsTriggers="true"  >

<ContentTemplate>
      
   
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

  

   
 
        <asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_my_main text-secondary"  Visible="true"        > 
              <asp:Label ID="label_logged_in" runat="server" Text="Label"></asp:Label>
    <asp:Panel ID="Panel_Main" runat="server" CssClass="Panel_Content_with_Textboxes text-secondary" Visible="true"        > 
    
  <asp:Panel ID="Panel3" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px"  > 
       <div  class="col-form text-left">  
       <h5>  &nbsp;&nbsp;<i class="fa fa-address-card" aria-hidden="true"></i>  &nbsp;&nbsp; Edit Account Information</h5>
               <h4>  &nbsp;&nbsp;Please fill out the account information and then click save.</h4>
           <p class="text-danger">
               <asp:Label ID="lbl_message" runat="server" Class="col-1 col-form-label" Text=""></asp:Label>
           </p>
        </div>
          <asp:Panel ID="Panel_registration" runat="server" CssClass="Panel_Content_with_Textboxes " style="top: 0px; left: 0px"  > 
        <div style='  overflow-y: scroll; overflow-x: scroll;'>  

            <div class="container py-5">
    <div class="row">
        <div class="col-md-10 mx-auto">
            <form>
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
                         <asp:TextBox ID="txt_Security_Question" CssClass="textarea" Class="form-control" runat="server" TextMode="MultiLine" Height="185px"></asp:TextBox>  
                   </i>
                             </div>
                    <div class="col-sm-3">
                         <i class="fa fa-reply">
                        <label for="inputState">Security Answer  :</label>
                       <asp:TextBox ID="txt_Security_Answer" Class="form-control" runat="server"></asp:TextBox>  
                         </i>
                    </div>
                    <div class="col-sm-3">
                              <i class="fa fa-user">
                        <label for="inputPostalCode">Email  :</label>
                      <asp:TextBox ID="txt_reg_email" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>  
                         </i>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                          <i class="fa fa-key">
                        <label for="inputContactNumber">Password  :</label>
                          <td> <asp:TextBox ID="txt_passwordmysql" runat="server" TextMode="Password"></asp:TextBox></td>  
                         </i>
                    </div>
                    <div class="col-sm-6">
                         <i class="fa fa-key">
                        <label for="inputWebsite">Confirm Password  :</label>
                      <asp:TextBox ID="txt_confirm_Password" runat="server" TextMode="Password"></asp:TextBox>  
                         </i>
                    </div>
                </div>
                
                    <asp:LinkButton runat="server" Name="btn_save"  ID="btn_save" 
        type="submit" class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
          OnClick="Button1_Click"  ToolTip="Click to save ."   > <i class="fa fa-save" aria-hidden="true"></i>&nbsp;Save </asp:LinkButton>

                   <br />
                 <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton1play" 
                                 title="Click to edit profile picture." 
                                Text="<i class='fa fa-image'></i> &nbsp;Edit Picture" 
                                ValidationGroup="edt" 
                                OnClick="Runapp4" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
                  <br />
  
            </form>
        </div>
    </div>
</div>
             
        </div>  
              </i>  
       </asp:Panel>
     </asp:Panel>
    

       </asp:Panel>                   
            <%-- <P>
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_logout" 
                                 title="Click to logout." 
                                Text="<i class='fa fa-sign-out'></i> &nbsp;Logout" 
                                ValidationGroup="edtasfdff" 
                                OnClick="Logout_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
                          
                          </P>--%>
   
       </asp:Panel>      
 


    <input id="textbox1" text="" visible="false" runat="server"  />
  

 <script src="/Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
 

 
  

       
    
    
 </ContentTemplate>
      </asp:UpdatePanel> 
   
  </asp:Content>
 

 
    
       
<%--</asp:Content>--%>

         
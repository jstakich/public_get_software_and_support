<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GetSoftwareAndSupport.Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:UpdatePanel ID="updPnl" runat="server" UpdateMode="Conditional" 
                ChildrenAsTriggers="true">

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
      <asp:Panel ID="Panel5" runat="server" CssClass="Panel_Content_my_main text-secondary" Visible="true"        > 
           <asp:Label ID="label_logged_in" runat="server" Text="Label"></asp:Label>
      <%--<asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_with_Textboxes"  Visible="true"        >--%> 
        
    <div class="row">

      
      
              <%--<asp:Panel ID="Panel_Main" runat="server" CssClass="Panel_Content_with_Textboxes" Visible="true"        >--%> 
                  <%--<div class="Panel_Content_with_Textboxes">--%>


                  <%--  --%>



 
             <%--   <h1 class="text-center">Welcome to Version 2.9 !</h1>--%>
          
               
                 <%--<p class="lead"><p class="text-danger">Estimated start date of this business - <strong> January 1 , 2021</strong></p>--%> 
    <%--     <p> &nbsp;&nbsp; If you need to update your .Net applications to target a newer framework or just need to make adjustments please let us know . No job is too small .   </p>
     --%>     

           

                      <%-- <p> </p> --%>
              <%--<p>&nbsp;&nbsp; - <strong>Owner / CIO  - Jeremy D. Stakich</strong>   <i style="font-size:72px" class="fa">&#xf08c;  <img alt="" style="border-style: solid; border-color: #4285F4 ; border-width: medium;" height="50" width="50" title="Click to view Jeremy's Profile on LinkedIn ." onClick="Go_To_Linked_In()" src="/pics/jeremys1.jpg"/> </i>   </p>--%>   
 <%--</div>--%>
           <%--</asp:Panel>--%>    
         <%--</asp:Panel>--%>  
     <asp:Panel ID="Panel2" runat="server" CssClass="Panel_Content_with_Textboxes"  Visible="true"        > 
        <div class="Panel_Content_with_Textboxes">
                  <h1 class="text-center">Welcome to Version 3.13 !</h1>
             <h5 class="text-center">Last Update - 1/8/2022</h5>
          <h1 class="text-center">Get Software And Support.com </h1>
             
            <h2 class="text-center"> .Net Software Development</h2>
           <br>
                  <br>  &nbsp;&nbsp;&nbsp;&nbsp; We use this site to publish APIs and Clickonce installs . If you need anything with regard to .Net please let us know.
             
           <br>  &nbsp;&nbsp; We will design new , or make changes to existing windows based software <strong>( .Net framework - C#.Net and VB.Net )</strong>  for individuals and businesses for very competitive 
           <br>  &nbsp;&nbsp;   prices . We mainly focus on <strong>Console</strong> , <strong>Winforms</strong> ,  and <strong> ASP.net Web Form Applications</strong> .    
              
       
             

              

                        <br>    &nbsp;&nbsp; If you need to update your .Net applications to target a newer framework or just need to make adjustments please let us know . No job is too small .    
     
       <br />  
                       <br />   
                    &nbsp;&nbsp;     
                            <strong>
                             
                            </strong>
                             &nbsp;&nbsp;     
                        Owner / CIO   - <strong>Jeremy D. Stakich</strong>      <img alt="" style="border-style: solid; border-color: #4285F4 ; border-width: medium;" height="50" width="50" title="Click to view Jeremy's Profile on LinkedIn ." onClick="Go_To_Linked_In()" src="/pics/jeremys1.jpg"/>     
                   
             <br>
              
                
                           


              
                
                             


              
                
                            <br>


              
                
            
        </div>

              </asp:Panel> 
       
   <asp:Panel ID="Panel3" runat="server" CssClass="Panel_Content_with_Textboxes"  Visible="true"        > 
        <div class="Panel_Content_with_Textboxes">
            <h2 class="text-center">Source Code on Github </h2>
           
             <br> &nbsp;&nbsp;If you are interesed in the source code for recording MP4 videos , you can find it on our Github below.
         <br />  &nbsp;&nbsp; <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://github.com/jstakich">https://github.com/jstakich</asp:HyperLink>

          
            <br />
            <br />
        </div>

               </asp:Panel>  


         <asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_with_Textboxes"  Visible="true"        > 
        <div class="Panel_Content_with_Textboxes">
            <h2 class="text-center">Google Apps Scripting </h2>
           
             <br> &nbsp;&nbsp;We also do a little Google Apps scripting.  
         <br />  &nbsp;&nbsp; If you have the need to extend your Sheets , Docs , or Gmail let us know ...  <asp:LinkButton ID="LinkButton1" runat="server"  OnClientClick="https://en.wikipedia.org/wiki/Chrome_Remote_Desktop" PostBackUrl="\Contact"> <strong>Contact Us</strong> </asp:LinkButton> .  

          
            <br />
            <br />
        </div>

               </asp:Panel> 

      <%--<asp:Panel ID="Panel4" runat="server" CssClass="Panel_Content_with_Textboxes"  Visible="true"        >--%> 
        <div class="Panel_Content_with_Textboxes">
           

            <div class="Panel_Content_with_Textboxes">
                 <h2 class="text-center">Open Projects: </h2>
                <br />
             <strong> &nbsp;&nbsp; 1.</strong>  (Project - MP4)     
                <br />
                <br />
             <strong>&nbsp;&nbsp;  1 a.</strong>  (Project - MP4) Video update on MP4 Project.    
                <br />
                 <%--<div style='  overflow-y: scroll; overflow-x: scroll;'>--%>  
                       
               &nbsp;&nbsp;  <video id="123" controls playsinline autoplay muted loop width="400" height="350"   " >
  <source src="https://getsoftwareandsupport.com/files/Videos/update1.mp4"    type="video/mp4"  >
  
Your browser does not support the video tag.
</video>
                   

  <br />
                 <strong>&nbsp;&nbsp; 1 b. </strong> Click below to record videos.    
<br />
              <%--<i class='fa fa-video-camera'></i>--%>
              &nbsp;&nbsp;   <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButtonww1" 
                                 title="Click to Record and Download and MP4." 
                                Text="<i class='fa-video-camera'></i> &nbsp;Record MP4" 
                                ValidationGroup="edt" 
                                OnClick="Runapp1" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
                  <br />
                 <strong>&nbsp;&nbsp; 1 c. </strong> Click below to play your previously recorded videos.    
<br />
                 &nbsp;&nbsp; <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton1play" 
                                 title="Click to view previously recorded videos." 
                                Text="<i class='fa fa-play'></i> &nbsp;Play Videos" 
                                ValidationGroup="edt" 
                                OnClick="Runapp3" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
                  <br />
             <strong> &nbsp;&nbsp;  1 d.</strong> (Project - MP4) - Status 1/2 complete. It works on many devices. On Apple be sure to use Safari browser. I still have some ajax and server work to do.    
            <br />
               <strong> &nbsp;&nbsp;    1 e.</strong>  (Project - MP4) - Security - Open to all users  
                <br />
                <br />
                  </div>
             <div class="Panel_Content_with_Textboxes">
                 <br />
                    <strong>   &nbsp;&nbsp;  2. </strong>(Project - Wordapp) Click here to view this area of the site  
                 <br />
                      &nbsp;&nbsp;   <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_search1sss" 
                                 title="Click to view project." 
                                Text="<i class='fa fa-database'></i> &nbsp;View Data" 
                                ValidationGroup="edt" 
                                OnClick="Runapp" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />

                      <br />
              <strong> &nbsp;&nbsp;   2 a.</strong> (Project - Wordapp) - Status 3/4 complete. Have to publish click once app that produces this data after templete is adjusted. 
                 <br />
             <strong>  &nbsp;&nbsp;   2 b. </strong>(Project - Wordapp) - Security - Private open to user.   
                 <br />
                 <br />
 </div>
           </div>
           
            
            
        </div>
              </asp:Panel>  
             



   <%-- </div>--%>

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

    &nbsp;&nbsp;  <input id="textbox1" text="" visible="false" runat="server"  />
  <%--</asp:Panel>--%>  


             
            
                 <asp:Panel ID="PanelComments1" runat="server" CssClass="Panel_Content_my_main text-secondary" Visible="true"     >      

     <asp:Panel ID="PanelComments" runat="server" CssClass="Panel_Content_with_Textboxes"  Visible="true"        > 
        
        
        <div>
            <div class="formDesign">
                     &nbsp;&nbsp;     <h1 class="text-center">Recent Comments</h1>
                <p> <strong>
              &nbsp;&nbsp;   <asp:Label ID="lbl_comments" runat="server" Text="Please leave a comment."></asp:Label>
                    </strong>
                    </p>
                <div class="div_toshow" id="div_toshow" runat="server">
               &nbsp;&nbsp;  <table style='  overflow-y: scroll; overflow-x: scroll;'>
                    
                    <tr>
                         <td class="auto-style1">Name</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtName" runat="server" Width="185px" Enabled="False" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Please Provide Name" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                        </td>
                     </tr>
                    <tr>
                         <td class="auto-style1">Email</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtEmailComment" runat="server" Width="185px" Enabled="False" ReadOnly="True"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmailComment" Display="Dynamic" ErrorMessage="Please Provide Email" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailComment" Display="Dynamic" ErrorMessage="Email ID is Incorrect" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1" style="height: 217px">Comment</td>
                        <td class="auto-style2" style="height: 217px">
                                  <asp:TextBox ID="txtComment" CssClass="textarea" Class="form-control" runat="server" TextMode="MultiLine" Height="185px"></asp:TextBox>  
                            <%-- <asp:TextBox ID="txtComment" CssClass="textarea" Height="44px"  Width="185px" Class="form-control" runat="server" TextMode="MultiLine" ></asp:TextBox>  --%>

                           <%-- <asp:TextBox ID="txtComment" runat="server" Height="44px" TextMode="MultiLine" Width="185px"></asp:TextBox>--%>
                        </td>
                        <td style="height: 217px">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtComment" ErrorMessage="Please Provide Comment" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">&nbsp;</td>
                        <td class="auto-style2">

                            
                       
                              <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_Submit" 
                                 title="Click to post comment." 
                                Text="<i class='fa fa-save'></i> &nbsp;Post Comment" 
                                ValidationGroup="edt" 
                                OnClick="btn_Submit_Click" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />

                        
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                    </div>
            </div>
            <h4 style="text-decoration:underline;">Comments:</h4>
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True"
    OnPageIndexChanging="OnPageIndexChanging" PageSize="3" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" CssClass="mydatagrid" ForeColor="Black" GridLines="Vertical" OnRowDataBound="GridView1_RowDataBound">
               <AlternatingRowStyle BackColor="#CCCCCC" />
    <Columns>
        <asp:TemplateField HeaderText="Image">
        <ItemTemplate>
                <asp:Image ID="Image1" Width="50" Height="50" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>

         <asp:BoundField ItemStyle-Width="0px" Visible="false" DataField="The_Image" HeaderText="The_Image" >
        <ItemStyle Width="0px" />
        </asp:BoundField>
        <asp:BoundField ItemStyle-Width="150px" DataField="Name" HeaderText="Name" >
        <ItemStyle Width="150px" />
        </asp:BoundField>
        <asp:BoundField ItemStyle-Width="0px" Visible="false" DataField="Email" HeaderText="Email" >
        <ItemStyle Width="0px" />
        </asp:BoundField>
        <asp:BoundField ItemStyle-Width="150px" DataField="Comment" HeaderText="Comment" >
        <ItemStyle Width="150px" />
        </asp:BoundField>
        <asp:BoundField ItemStyle-Width="150px" DataField="Comment_Date" HeaderText="Comment_Date" >        
        <ItemStyle Width="150px" />
        </asp:BoundField>
    </Columns>
               <FooterStyle BackColor="#CCCCCC" />
               <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
               <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
               <SortedAscendingCellStyle BackColor="#F1F1F1" />
               <SortedAscendingHeaderStyle BackColor="#808080" />
               <SortedDescendingCellStyle BackColor="#CAC9C9" />
               <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
            
        </div>
   
    
     </asp:Panel>  

     </asp:Panel>  

</ContentTemplate>
           <Triggers>
 
    </Triggers>
</asp:UpdatePanel>  
</asp:Content>

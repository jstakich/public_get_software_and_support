<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyVideos.aspx.cs" Inherits="GetSoftwareAndSupport.MyVideos" %>
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
      <asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_with_Textboxes"  Visible="true"        > 
      <h2 class="text-center">Recorded Videos </h2>
     
    
          <p class="text-danger">
                    
                    &nbsp;&nbsp; <asp:Label ID="lbl_message" runat="server" Class="col-1 col-form-label"   Text=""></asp:Label> 
                   <br />
              &nbsp;&nbsp; <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton1play" 
                                 title="Click to refresh videos." 
                                Text="<i class='fa fa-refresh'></i> &nbsp;Refresh Videos" 
                                ValidationGroup="edt" 
                                OnClick="btnRefreshVideos" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
                </p>
         <%-- <p class="text-secondary"> <strong>&nbsp;&nbsp;   </strong> Click Refresh to reload the videos .
            </p>--%>
<%--<br />--%>
                 <br />
                  
           <p  >
            <div style='  overflow-y: scroll; overflow-x: scroll;'>  
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True"
    OnPageIndexChanging="OnPageIndexChanging"
                OnRowCancelingEdit="GridView1_RowCancelingEdit "   
            OnRowEditing="GridView1_RowEditing"
            OnRowUpdating="GridView1_RowUpdating"
            OnRowDeleting="GridView1_RowDeleting"
                PageSize="3" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" CssClass="mydatagrid" ForeColor="Black" GridLines="Vertical" OnRowDataBound="GridView1_RowDataBound">
               <AlternatingRowStyle BackColor="#CCCCCC" />
    <Columns>
         <asp:TemplateField HeaderText="Edit Options">  
                    <ItemTemplate>  
                      
                                 <asp:LinkButton runat="server" Name="btn_Edit11"  ID="btn_Edit11" 

type="submit"
                          class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
                          CommandName="Edit" 
                          ToolTip="Click to edit."    >
                          <i class="fa fa-edit" aria-hidden="true"></i>&nbsp;Edit
                           </asp:LinkButton>

                    </ItemTemplate>  
                    <EditItemTemplate>  
                     
                    
                        
                       
                       
                        
                         <asp:LinkButton runat="server" Name="btn1_delet1"  ID="btn1_delet1" 
                          type="submit"
                          class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
                          CommandName="Delete"
                          OnClientClick="return confirm_delete();" 
                          ToolTip="Delete item in database."    >
                          <i class="fa fa-trash" aria-hidden="true"></i>&nbsp;Delete
                           </asp:LinkButton>
                        
                         

                          <asp:LinkButton runat="server" Name="btn_cancel1"  ID="btn_cancel1" 
                          type="submit"
                          class="btn btn-primary custom_ex_med_new_Active_u_menu_button fa" 
                          CommandName="Cancel" 
                          ToolTip="Click to cancel."    >
                          <i class="fa fa-window-close" aria-hidden="true"></i>&nbsp;Cancel
                           </asp:LinkButton>

                        
                    </EditItemTemplate>  
                </asp:TemplateField> 
      

        
          <asp:TemplateField HeaderText="Videos">  
                        <ItemTemplate>  
                            <video width="130" height="130" controls muted loop playsinline autoplay >  
                                <source src='<%#Eval("link")%>' type="video/mp4">  
                            </video>  
                        </ItemTemplate>  
                    </asp:TemplateField>  

         <asp:TemplateField HeaderText="Upload_Date">
  <ItemTemplate>
<asp:Textbox id="the_date" Enabled="False" ReadOnly="True" runat="server" Text='<%# Eval("the_date") %>'> </asp:Textbox>
 </ItemTemplate>
 </asp:TemplateField>  
       
        <asp:TemplateField Visible="false" HeaderText="Id">
  <ItemTemplate>
<asp:Textbox id="txtId" Visible="false" Enabled="False" ReadOnly="True" runat="server" Text='<%# Eval("id") %>'> </asp:Textbox>
 </ItemTemplate>
 </asp:TemplateField>  

          <asp:TemplateField HeaderText="Email">
  <ItemTemplate>
<asp:Textbox id="Email" Enabled="False" ReadOnly="True" runat="server" Text='<%# Eval("Email") %>'> </asp:Textbox>
 </ItemTemplate>
 </asp:TemplateField>  

       <asp:TemplateField HeaderText="Organization">
  <ItemTemplate>
<asp:Textbox id="Organization" Enabled="False" ReadOnly="True" runat="server" Text='<%# Eval("Organization") %>'> </asp:Textbox>
 </ItemTemplate>
 </asp:TemplateField>  

         

   

         
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
               <p>
              <br />
          <div id="Test1" runat="server">

    </div>
   </asp:Panel>    
        <input id="textbox1" text="" visible="false" runat="server"  />
         </asp:Panel>  
</ContentTemplate>
           <Triggers>
 
    </Triggers>
</asp:UpdatePanel>  
</asp:Content>

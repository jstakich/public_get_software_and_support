<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PCI_Data.aspx.cs" Inherits="GetSoftwareAndSupport.PCI_Data" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


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
        </li>--%>                     <%--<li> 
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButton_EditAccount" 
                                 title="Click to edit account." 
                                Text="<i class='fa fa-address-card'></i> &nbsp;Edit Account" 
                                ValidationGroup="edtffffa" 
                                OnClick="Edit_Account_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Visible="True" />
                          
                          
                           </li>--%>  <%--                    <%
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

    <div style='  overflow-y: auto; overflow-x: auto; '
    <p class="text-secondary">


       &nbsp;&nbsp; <asp:Label ID="Label2" runat="server" BorderStyle="Double" class="text-dark" Font-Bold="True" Font-Size="Larger"   Text="PCI Compliant Document Search Tool"></asp:Label>
      <br /> &nbsp;&nbsp;  <asp:Label ID="Label1" class="text-secondary" runat="server" Font-Size="Medium" Text="Enter a keyword within the doument and click search."></asp:Label>

 <div class="container py-5">
    <div class="row">
        <div class="col-md-10 mx-auto">
            <form>
                <div class="form-group row">
                    <div class="col-sm-6">
                         <i class="fa fa-search">
                          <asp:TextBox ID="TextBox1aa" runat="server" class="text-secondary" OnTextChanged="run_this" Font-Size="Larger" Height="28px" Width="411px" AutoPostBack="True" ></asp:TextBox>
                    </i>
                             </div>
                    <div class="col-sm-6">
                         <i class="fa fa-search">
                       <asp:CheckBox ID="cbox_include_Date" class="text-secondary"  runat="server" Font-Size="Larger" OnCheckedChanged="cbox_include_Date_CheckedChanged" Text="Search Date only" AutoPostBack="True" />
                    </i>
                             </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                          <i class="fa fa-search">
                       <asp:CheckBox ID="cbox_include_Date2" class="text-secondary"  runat="server" Font-Size="Larger" OnCheckedChanged="cbox_include_Date0_CheckedChanged" Text=" Search Date and Keyword" AutoPostBack="True" />
                     </i>
                              </div>
                    <div class="col-sm-6">
                         <i class="fa fa-calendar">
                      <asp:TextBox ID="TextBox2" runat="server" Font-Size="Larger" Height="40px" class="text-secondary" OnTextChanged="TextBox2_TextChanged" TextMode="DateTimeLocal" Width="411px" AutoPostBack="True"></asp:TextBox>  
                  </i>
                             </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                        
                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_Clear" 
                                 title="Click to clear date." 
                                Text="<i class='fa fa-eraser'></i> &nbsp;Clear Date" 
                                ValidationGroup="edt" 
                                OnClick="Button3_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />


                    </div>
                    <div class="col-sm-3">
                       
                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_search" 
                                 title="Click to search." 
                                Text="<i class='fa fa-database'></i> &nbsp;Search" 
                                ValidationGroup="edt" 
                                OnClick="Button1_Click" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
                        

                    </div>
                    <div class="col-sm-3">
                       

                        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_Reload" 
                                 title="Click to reload page." 
                                Text="<i class='fa fa-refresh'></i> &nbsp;Reload Page" 
                                ValidationGroup="edt" 
                                OnClick="Button2_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />


                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-sm-6">
                        



                    </div>
                    <div class="col-sm-6">
                        
                        

                    </div>
                </div>
                 


  
            </form>
        </div>
    </div>
</div>

    
    
    
    
         </div>
        <div style='  overflow-y: scroll; overflow-x: scroll;''
       /* width: 300px;
        height: 100px;*/
        border: 1px solid #2b00ff;'> 
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="mydatagrid">
            <AlternatingRowStyle BackColor="#CCCCCC" />
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
           </asp:Panel> 

</asp:Content>

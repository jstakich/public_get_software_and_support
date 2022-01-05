<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Record_MP4.aspx.cs" Inherits="GetSoftwareAndSupport.Record_MP4" %>
 

    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
   
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
            
 
                     

                   
                </ul>  
            </div>  
            <!--Menu End Here-->  
        </div>  
    </nav>  
 
    <asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_my_main text-secondary"  Visible="true"        > 

         <asp:Label ID="label_logged_in" runat="server" Text="Label"></asp:Label>

    <asp:Panel ID="Panel_Main" runat="server" CssClass="Panel_Content_with_Textboxes text-secondary" Visible="true"        > 
        <%--<asp:Label ID="Label1" runat="server" Text="Click to view video on server after upload.     " Font-Bold="True" ForeColor="Red"></asp:Label>
         <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View Video" />--%>

       <%-- <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="LinkButtonww1" 
                                 title="Click to view the videos you have recorded." 
                                Text="<i class='fa-video-camera'></i> &nbsp;View your Videos" 
                                ValidationGroup="edt" 
                                OnClick="ViewVideos" 
            
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />--%>
         <div id="new-header">
        <script>
            $("#new-header").load("app.html");
           // $("#new-header").load("app2.html");
        </script>
</div> 
          
          <%--<asp:TextBox ID="txt_email" runat="server" Class="form-control" Text=""  maxlength="100"   placeholder="" autocomplete="put_this_at_a_random_string"   type="text"        AutoCompleteType="Disabled"    ></asp:TextBox>--%>
  
           <script src="/Scripts/jquery-3.4.1.js"></script> 
 
        <%--<asp:Button ID="btn_testa" runat="server" OnClick="Save" Text="Button" />--%>
       <%-- <div  runat="server" id="theDiv">--%>
          <%--<button type="button"    class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" id="start">Start camera</button>
            <button type="button"  class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" id="record" disabled>Start Recording</button>

            <button type="button"   class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" id="play" disabled>
                <i class="fa fa-play" aria-hidden="true">
                </i>&nbsp;Play
            </button>
            <button type="button"   class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" id="download" disabled>
                <i class="fa fa-download" aria-hidden="true">
                </i>&nbsp;Download
            </button>--%>
    <%--  </div> --%>

       <%--  <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                id="start"
                                type="submit" 
                                 title="Click to Start camera" 
                                Text="<i class='fa fa-address-card'></i> &nbsp;Start camera" 
                                ValidationGroup="edtffffa"  
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"  />


             

         <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                id="record"
                                type="submit" 
                                 title="Click to Start Recording" 
                                Text="<i class='fa fa-address-card'></i> &nbsp;Start Recording" 
                                ValidationGroup="edtffffa"  
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" Enabled="False" />




            


        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                id="play"
                                type="submit" 
                                 title="Click to Play" 
                                Text="<i class='fa fa-play'></i> &nbsp;Play" 
                                ValidationGroup="edtffffa"  
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"  Enabled="False" />

        <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                               id="download"
                                type="submit" 
                                 title="Click to Download" 
                               
                                Text="<i class='fa fa-download'></i> &nbsp;Download" 
                                ValidationGroup="edtffffa"  
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa"  Enabled="False" />--%>


             

        
           </asp:Panel> 
           </asp:Panel> 
                <form method="POST" enctype="multipart/form-data" id="fileUploadForm">
    <script src="jeremy/js/adapter-latest.js"></script>
   <%-- <script src="jeremy/js/main.js" async></script>--%>
      <%-- <script src="jeremy/js/main.js" async></script>--%>
  
        <script src="jeremy/js/main.js" async></script>
<%--     <script src="jeremy/js/Video.js" async></script>--%>
 <%--<asp:Panel ID="Panel2" runat="server" CssClass="Panel_Content_with_Textboxes text-secondary" Visible="true"        >--%> 
   
         <input id="textbox1" style="color:transparent !important;  box-shadow: 0px 0px 0px transparent  !important; border-radius: 0px  !important; transition: all 0.0s ease 0s  !important;  border-color:transparent !important;" text="" visible="true" runat="server" disabled="disabled"  />
    <br />
    <input id="textbox_Url" text="" style="color:transparent !important;  box-shadow: 0px 0px 0px transparent  !important; border-radius: 0px  !important; transition: all 0.0s ease 0s  !important;  border-color:transparent !important;" visible="true" runat="server" disabled="disabled"  />
               <%-- </asp:Panel>  --%>   
     </form>
<%--           <P>
                            <asp:LinkButton runat="server" 
                                class="btn btn-link custom_ex_med_new_Active_u_menu_button fa" 
                                ID="btn_logout" 
                                 title="Click to logout." 
                                Text="<i class='fa fa-sign-out'></i> &nbsp;Logout" 
                                ValidationGroup="edtasfdff" 
                                OnClick="Logout_Click" 
                                CssClass="btn btn-link custom_ex_med_new_Active_u_menu_button fa" />
                          
                          </P>--%>
       
 </ContentTemplate>
            <%--<Triggers>
                  <asp:AsyncPostBackTrigger ControlID="btn_testa" EventName="Click" />
               </Triggers>--%>
      </asp:UpdatePanel> 
   
  </asp:Content>
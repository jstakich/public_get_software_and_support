<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="App_Logout.aspx.cs" Inherits="GetSoftwareAndSupport.Account.App_Logout" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="updPnl" runat="server">
<ContentTemplate>
        
                 
         <header>
        <script type="text/javascript">
            function getback() { window.history.forward(1); }
            setTimeout("getback()", 0);
            window.onload = function () { null };
        </script>
    </header>
       
       
       
         
<%-- Page - Set Shadow and text Color--%>   
<asp:Panel ID="Panel_Main" runat="server" CssClass="PanelPaddingMain1 text-secondary" Visible="true"        > 
      
    
<%-- Main Heading--%>  
<asp:Panel ID="Panel_Heading1" runat="server"  CssClass="PanelPaddingHead" Visible="true"  >   
        <blockquote class="blockquote text-center"> 
 <p class="h2"><asp:Image ID="Image2" runat="server"   Height="51px" ImageUrl="~/pics/GSAS.png" Width="56px" />&nbsp;Thank you for using GetSoftwareAndSupport.com! </p>
                
<p class="mb-0"> <asp:Label ID="lbl_username" runat="server"  BorderStyle="None" Text=""   ></asp:Label>
              
 <asp:Label ID="space" runat="server"  BorderStyle="None" Text=""  ></asp:Label>    
              
  <h4> <strong>  <asp:Label ID="lbl_level_access" runat="server" BorderStyle="None"   Text="You are now logged out."></asp:Label> </strong> </h4>
 
        </blockquote> 
</asp:Panel>   


  <%-- Sub Heading--%>
<%--<asp:Panel ID="Panel_Heading2" runat="server"  CssClass="PanelPadding_buttons" Visible="true"   > 
        <div class="row ">
                <div class="col">  </div>
                <div class="centerthis">  </div>
                <div class="col">  </div>
        </div>
</asp:Panel>   --%>
                        
                        
 <%-- Instructions--%>                                      
<asp:Panel ID="Panel_Instructions" runat="server" CssClass="PanelPadding_Instructions" Visible="true"  > 
        <div  class="col-form text-left">  
      <h4>   Please login again to use the application.</h4>
        </div>
</asp:Panel> 
     
           
  <%-- Content 1--%>  
<asp:Panel ID="Panel2" runat="server" CssClass="Panel_Content_with_Textboxes" Visible="true"        >   
   
                  <br />
                     

                     <div class="form-row">
        <div class="form-group col-md-6">
     
         
      
           <a runat="server"   class="col-form-label-lg text-secondary"  title="Click to Login" href="/Account/Login"> <img src="../icon/gg_FZr_icon.ico" height="40px" width="40px" />&nbsp;&nbsp;Go to Login</a> 
             

             
          </div>
  
                         </div>



      <div class="form-row">
        
     
                         </div>
              
       
</asp:Panel>  
    
      
  
    
                                       
                         
</asp:Panel>  
 
     
    
       
       
       
       
        
        
    <footer>
          <br />
          <br />
          <br />
                 </footer>




         </ContentTemplate>
            </asp:UpdatePanel>  


</asp:Content>

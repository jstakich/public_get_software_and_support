<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditProfilePicture.ascx.cs" Inherits="GetSoftwareAndSupport.EditProfilePicture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:UpdatePanel ID="updPnl" runat="server"    UpdateMode="Conditional" 
                ChildrenAsTriggers="true"   >
            <ContentTemplate>

     

     <asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_my_main text-secondary"  Visible="true"        > 
         <asp:Label ID="label_logged_in" runat="server" Text="Label"></asp:Label>

         <asp:Panel ID="Panel_Main" runat="server" CssClass="Panel_Content_with_Textboxes text-secondary" Visible="true"        > 
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
          OnClick="Upload_File"  ToolTip="Click to Upload file." Visible="True"   >
        <i class="fa fa-image" aria-hidden="true"></i>&nbsp;Upload
      </asp:LinkButton>
<hr />
 </div>

                </asp:Panel> 
           <input id="textbox1" text="" visible="false" runat="server"  />
            </asp:Panel> 

               
   
    </ContentTemplate>
             <Triggers>
               <asp:PostBackTrigger ControlID = "btnUpload" />      
    </Triggers>
</asp:UpdatePanel>  

</asp:Content>
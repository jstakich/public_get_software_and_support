<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Record_Comment.aspx.cs" Inherits="GetSoftwareAndSupport.Record_Comment" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="Panel_Content_my_main text-secondary"  Visible="true"        > 
    <asp:Panel ID="Panel_Main" runat="server" CssClass="Panel_Content_with_Textboxes text-secondary" Visible="true"        > 
 
    <h2><%: Title %> Us</h2>
    <h3>GetSoftwareAndSupport.com</h3>
       <button id="btnSnap"   onclick="takePhoto()">Snap Photo</button>
<input type="button" id="button1" value="Save_Image_Ajax" onclick="Javascript_CSharp_Save_Imageeee()" />

          <%-- Start of code that saves pic --%>
        
           <script src="/Scripts/jquery-3.4.1.js"></script> 
   
    <canvas id="canvas" width="200" height="100"></canvas>
    <canvas id="context" width="200" height="100"></canvas>
    <canvas id="video" width="200" height="100"></canvas>
    <canvas id="videoObj" width="200" height="100"></canvas>
   <script type="text/jscript">
        //var canvas, context, video, videoObj;

        $(function () {

            canvas = document.getElementById("canvas");
            context = canvas.getContext("2d");
            video = document.getElementById("video");

            // different browsers provide getUserMedia() in differnt ways, so we need to consolidate 
            navigator.getUserMedia = navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia;

            if (navigator.getUserMedia) {
                navigator.getUserMedia(
                    { video: true }, // which media
                    function (stream) {   // success function
                        video.src = window.URL.createObjectURL(stream);
                        video.onloadedmetadata = function (e) {
                            video.play();
                        };
                    },
                    function (err) {  // error function 
                        console.log("The following error occured: " + err.name);
                    }
                );
            }
            else {
                console.log("getUserMedia not supported");
            }
        });

       




    </script>
        
        
         <%-- End of code that saves pic --%>

       <%-- Start of code that does recording --%>
         <video autoplay></video>
           <div class="select">
    <label for="audioSource">Audio source: </label><select id="audioSource"></select>
  </div>

  <div class="select">
    <label for="videoSource">Video source: </label><select id="videoSource"></select>
  </div>

  <video autoplay muted playsinline></video>

    
  <script src="/jeremy/ascript.js"></script> 
         
        <script type="text/jscript">
         function takePhoto() {
            context.drawImage(video, 0, 0, 640, 480);
            alert("Photo Saved Successfully!");
        }
          </script>
         <%-- End of code that does recording --%>
        
         
        
    <script type="text/javascript">
        function Javascript_CSharp_Save_Imageeee(e) {
            var image = document.getElementById("canvas").toDataURL("image/png");

            var imagebase64data = canvas.toDataURL("image/png");
           // imagebase64data = imagebase64data.replace('data:image/png;base64,', '');  
           // image = image.replace('data:image/png;base64,', '');
            alert(image);

            $.ajax({
                type: "POST",
                
                url: "/WebForm1.aspx/C_Sharp_Save_Image",
                data: '{ "imageData" : "' + image + '" }',
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                success: function (msg) {
                    alert('Image saved successfully !');
                }
            });
        };
           
    </script>
    <script type="text/jscript">

        function Javascript_CSharp_Save_Image(e) {
            $.ajax({
                type: "POST",
                url: "/WebForm1.aspx/C_Sharp_Save_Image",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    alert(data.d);
                },

                error: function () { alert("Ajax Error"); }
            });
        };
    </script>

        
        
        
        
        
        <p class="lead"><p class="text-danger">Estimated start date of this business - <strong> January 1 , 2021</strong></p> 
            
          <p> &nbsp;&nbsp;  We are a new up and coming software development and tech support company that will soon be offering remote desktop support to both individuals at home and at businesses in the near future . Currently we are only in the development and testing phases of this business but hope to go live on <strong>January 1, 2021</strong> . </p>
      <p> &nbsp;&nbsp; Our business model was built in consideration of the current dilemma our country is facing in hopes that we can be of assistance to others remotely while at the same time placing no one in harm's way . We will focus highly on quality , friendly service , and a quick turnaround rate both with our software development and remote tech support .</p>
            <p> <strong> Owner / CIO  </strong></p> 
            <p> - <strong>Jeremy D. Stakich</strong>   <i style="font-size:72px" class="fa">&#xf08c;  <img alt="" style="border-style: solid; border-color: #4285F4 ; border-width: medium;" height="50" width="50" title="Click to view Jeremy's Profile on LinkedIn ." onClick="Go_To_Linked_In()" src="/pics/jeremys1.jpg"/> </i>   </p>   
  </asp:Panel> 
          </asp:Panel> 
</asp:Content>

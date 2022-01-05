<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ExternalLogins._Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row form-group" style="margin-top: 40px;">
        <div class="col-md-12">
            <asp:Button CssClass="btn btn-default" ID="GoogleBtn" runat="server" Text="Login with Google account" OnClick="GoogleBtnClick"></asp:Button>
            <asp:Button CssClass="btn btn-default" ID="FacebookBtn" runat="server" Text="Login with Facebook account" OnClick="FacebookBtnClick"></asp:Button>
        </div>
    </div>
    <div class="row form-group">
        <h3 class="col-md-12">
            User Info:
        </h3>
        <div class="col-md-12">
            <asp:Literal ID="txtResponse" runat="server">External user info will populate here in json format.</asp:Literal>
        </div>
    </div>
</asp:Content>

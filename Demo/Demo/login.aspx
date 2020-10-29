<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Demo.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Đăng nhập trang quản trị</h1>
        <div id="ndcontent">
           <h4>User Name:</h4>
            <asp:TextBox ID="txtUserName" Width="300px" Height="20" runat="server"></asp:TextBox>
            <h4>Password:</h4>
            <asp:TextBox ID="txtPassword" Width="300px" Height="20" TextMode="Password" runat="server"></asp:TextBox>
        <br /><br />
            
            <asp:Button ID="btnLogin"  runat="server" Text="Log in" Height="29px" Width="94px" OnClick="btnLogin_Click" /> 
       <h4>
           <asp:Label ID="lblThongBao" runat="server" Text=""></asp:Label>
       </h4>
            </div>
</asp:Content>

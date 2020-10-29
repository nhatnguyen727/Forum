<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ChiTietADD.aspx.cs" Inherits="Demo.ChiTietADD" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Thêm nội dung</h1>
        <div id="ndcontent">
            <h4>Chọn bản tin: </h4>
            <asp:DropDownList ID="drBantin" runat="server" Height="30px" Width="404px" AutoPostBack="True" ></asp:DropDownList>
              <h4>Tiêu đề bản tin</h4>  
            <asp:TextBox ID="txtTieuDe" runat="server" Height="16px" Width="593px"></asp:TextBox>
           <h4>Nội dung :</h4>
            <CKEditor:CKEditorControl ID="txtNoiDung" runat="server" Width="599px"></CKEditor:CKEditorControl>

            <br />

            <asp:Button ID="btnInsert" runat="server" Text="Thêm" Height="39px" Width="150px" OnClick="btnInsert_Click" />
        
        </div>
</asp:Content>

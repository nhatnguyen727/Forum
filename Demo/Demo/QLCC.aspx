<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="QLCC.aspx.cs" Inherits="Demo.QLCC" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>Chỉnh sửa</h1>

    <div id="ndcontent">
            <h4>Chọn bản tin:</h4>
            <asp:DropDownList ID="drBantin" runat="server" Height="30px" Width="404px" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="noiDung" DataValueField="IDBanTin"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BlogConnectionString %>" SelectCommand="SELECT [IDBanTin], [noiDung] FROM [BanTin]"></asp:SqlDataSource>
          <h4>Tiêu đề bản tin</h4>  
            <asp:TextBox ID="txtTieuDe" runat="server" Height="16px" Width="593px"></asp:TextBox>
           <h4>Nội dung :</h4>
            <ckeditor:ckeditorcontrol ID="txtNoiDung" runat="server" Width="599px"></ckeditor:ckeditorcontrol>

            <br />

            <asp:Button ID="btnInsert" runat="server" Text="Cập nhật" Height="39px" Width="150px" OnClick="btnInsert_Click" />
        
            <br />
            <br />
    <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
            <asp:BoundField DataField="tieuDe" HeaderText="tieuDe" SortExpression="tieuDe" />
            <asp:ButtonField CommandName="Select" Text="Edit" />
            <asp:ButtonField CommandName="del" Text="Delete" />
        </Columns>
      
        
       
            </asp:GridView>

        

        
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BlogConnectionString %>" SelectCommand="SELECT [ID], [tieuDe] FROM [ChiTiet] ORDER BY [ID] DESC"></asp:SqlDataSource>

        

        
        </div>
</asp:Content>

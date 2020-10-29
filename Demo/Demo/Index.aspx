<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Demo.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Tin mới nhất</h1>
        <div id="ndcontent">
            
            <asp:Repeater ID="rpChiTiet" runat="server">
                <ItemTemplate>
                    <ul>
                        <li>
                            <a href="chitiet.aspx?idbantin=<%# Eval("IDBanTin") %>&id=<%# Eval("ID") %> "> <%# Eval("tieuDe") %></a>
                        </li>


                    </ul>
                </ItemTemplate>
            </asp:Repeater>
                  
        </div>
</asp:Content>

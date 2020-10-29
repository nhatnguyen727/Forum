﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="chitiet.aspx.cs" Inherits="Demo.chitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rpBanTin" runat="server">
        <ItemTemplate>
            <h1><%# Eval("noiDung") %></h1>

        </ItemTemplate>

    </asp:Repeater>
    
        <div id="ndcontent">
            
            <asp:Repeater ID="rpChiTiet" runat="server">
                <ItemTemplate>
                    <h3 style="color:red"><%# Eval("tieuDe") %> </h3>
                <p style="text-align:right; ">
                    Cập nhật: <%# Eval("ngayDang") %><br />
                    Số lần xem: <%# Eval("lanXem") %>
                </p>
                    <%# Eval("noiDung") %>
                </ItemTemplate>

            </asp:Repeater>

            
                  <br />
            <br />
            
            <br />

            
                  <h3 style="color:deepskyblue">Xem thêm bản tin
                      <ul>
                          <asp:Repeater ID="rpRanDom" runat="server">
                          <ItemTemplate>
                              <li>
                             <a href="chitiet.aspx?idbantin=<%# Eval("IDBanTin") %>&id=<%# Eval("ID") %> "> <%# Eval("tieuDe") %></a>

                              </li>

                          </ItemTemplate>

                      </asp:Repeater>
                      </ul>
                      
                  </h3>
        </div>
</asp:Content>

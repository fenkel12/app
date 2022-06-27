<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ccc.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="WebForm2.aspx">添加用户</a>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="查询"  OnClick="Button1_Click"/>
    <asp:Repeater ID="Repeater1" runat="server">
        
        <ItemTemplate>
            <table>
                <tr>
                    <th>用户编号</th>
                    <th>姓名</th>
                    <th>性别</th>
                    
                    <th>手机号码</th>
                    <th>注册日期</th>
                    <th>类型</th>
                    <th>操作</th>
                </tr>
                <tr>
                    <td><%#Eval("id") %></td>
                    <td><%#Eval("Name") %></td>
                    <td><%#Eval("Gender") %></td>
                    <td><%#Eval("Telephone") %></td>
                    <td><%#Eval("Regdate","{0:yyyy年MM月dd日}") %></td>
                    <td><%#Eval("userType","{0}")=="1"?"VIP":"" %></td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("id") %>' OnClick="LinkButton1_Click"><%#Eval("userType","{0}")=="1"?"取消VIP":"设置VIP" %><</asp:LinkButton></td>

                </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

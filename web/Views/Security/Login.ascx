<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="web.Views.Security.Login1" %>

        <div>
            Welcome to HIS</div>
        <table>
            <tr><td>User Name</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr><td>Password</td>
                <td>
                    <asp:TextBox ID="txtUserPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr><td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="GO" />
                </td>
            </tr>
        </table>
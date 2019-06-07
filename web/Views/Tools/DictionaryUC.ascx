<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WordUC.ascx.cs" Inherits="web.Views.Tools.DictionaryUC" %>
<style type="text/css">
    .auto-style1 {
        width: 526px;
    }
    .auto-style2 {
        width: 154px;
    }
</style>
<table border="1" cellpadding="1" cellspacing="1">
    <tr>
        <td class="auto-style2">Record Id</td>
        <td class="auto-style1">
            <asp:Label ID="id" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Find" />
        </td>
    </tr>
        <tr>
        <td class="auto-style2">Word In English</td>
        <td class="auto-style1">
            <asp:TextBox ID="en" runat="server" Width="483px"></asp:TextBox>
            </td>
    </tr>
        <tr>
        <td class="auto-style2">Word In Arabic</td>
        <td class="auto-style1">
            <asp:TextBox ID="ar" runat="server" Width="482px"></asp:TextBox>
            </td>
    </tr>
        <tr>
        <td class="auto-style2">Created by</td>
        <td class="auto-style1">
            <asp:Label ID="cb" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; @&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="co" runat="server" Text="Label"></asp:Label>
            </td>
    </tr>
        <tr>
        <td class="auto-style2">Updated by</td>
        <td class="auto-style1">
            <asp:Label ID="ub" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; @&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="uo" runat="server" Text="Label"></asp:Label>
            </td>
    </tr>
        <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="New" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
            </td>
    </tr>
</table>

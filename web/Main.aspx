<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="web.Main" %>

<%@ Register src="Views/Security/Login.ascx" tagname="Login" tagprefix="uc1" %>

<%@ Register src="Views/Tools/DictionaryUC.ascx" tagname="DictionaryUC" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <uc1:Login ID="Login1" runat="server" />
        <hr />
        <table style="width:100%">
            <tr>
                <td width="30%">
                    <asp:TreeView ID="TreeView2" runat="server" OnSelectedNodeChanged="TreeView2_SelectedNodeChanged">
                    </asp:TreeView>
                </td>
                <td>
                    <uc2:DictionaryUC ID="DictionaryUC1" runat="server"  Visible="False" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

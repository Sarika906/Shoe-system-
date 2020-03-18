<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #FF6666">
            Are you sure you want to delete this record
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Btnyes" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Yes" OnClick="Btnyes_Click" />
            <asp:Button ID="btnNo" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 127px; top: 52px; position: absolute" Text="No " />
        </div>
    </form>
</body>
</html>

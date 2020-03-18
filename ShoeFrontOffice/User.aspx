<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #FF6666">
            <br />
            First Name
            <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 82px; top: 34px; position: absolute"></asp:TextBox>
            <br />
            <br />
            Last Name
            <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 84px; top: 70px; position: absolute"></asp:TextBox>
            <br />
            <br />
            Email Address
            <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 102px; top: 110px; position: absolute"></asp:TextBox>
            <br />
            <br />
            Home Address
            <asp:TextBox ID="TextBox10" runat="server" style="z-index: 1; left: 106px; top: 148px; position: absolute"></asp:TextBox>
            <br />
            <br />
            Telephone Number
            <asp:TextBox ID="TextBox11" runat="server" style="z-index: 1; left: 131px; top: 186px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 243px; position: absolute" Text="Add" OnClick="btnok_Click" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 16px; top: 344px; position: absolute" Text="lblError"></asp:Label>
            <br />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 74px; top: 243px; position: absolute" Text="Cancel" />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 281px; position: absolute; right: 707px" Text="Ok" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shoes.aspx.cs" Inherits="Shoes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 321px; background-color: #FF6666">
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 164px; top: 260px; position: absolute" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 246px; top: 257px; position: absolute" Text="Edit" />
            <br />
            Shoe form
            <br />
            <br />
            Shoe Brand&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 98px; top: 72px; position: absolute"></asp:TextBox>
            <br />
            <br />
            Shoe Colour&nbsp; <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 97px; top: 110px; position: absolute"></asp:TextBox>
            <br />
            <br />
            Shoe Size&nbsp; <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 98px; top: 147px; position: absolute"></asp:TextBox>
            <br />
            <br />
            Shoe Style
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 98px; top: 187px; position: absolute; bottom: 314px"></asp:TextBox>
            <br />
            <br />
            In stock?
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 70px; top: 224px; position: absolute" />
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 70px; top: 261px; position: absolute; height: 26px; width: 58px" Text="Cancel" />
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 10px; top: 262px; position: absolute" Text="Ok" OnClick="btnOk_Click" />
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 18px; top: 307px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>

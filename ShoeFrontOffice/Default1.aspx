<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default1.aspx.cs" Inherits="Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF6699;
            height: 351px;
        }
        .auto-style2 {
            color: #000000;
        }
        .auto-style3 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Shoe Sensation<br />
            <p style="background-color: #FF6666">
                <span class="auto-style2">Home Page&nbsp;&nbsp;&nbsp;&nbsp; Shoes&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; My Favourites&nbsp; My Shopping Cart&nbsp;&nbsp;&nbsp; </span>
                <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 417px; top: 72px; position: absolute; width: 152px">VIEW ORDER HISTORY</asp:TextBox>
            </p>
            <span class="auto-style2"><span class="auto-style3">Products</span>
            <br />
            <br />
            Heels <br />
            <br />
            Clear heels
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 291px; top: 155px; position: absolute">Create account</asp:TextBox>
            <br />
            <br />
            Heeled Boots<br />
            <br />
            Court Heels<br />
            <br />
            Sock Boots </span>
            <br />
&nbsp;<br />
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 14px; top: 337px; position: absolute">ADD SHOES</asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 291px; top: 116px; position: absolute">Sign in </asp:TextBox>
            <br />
            </strong>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>

public partial class _Default : System.Web.UI.Page
{
  //this function handles the load event for the page 
  protected void Page_Load(object sender, EventArgs e)
{
  //if this is the first time the page is displayed
  if (IsPostBack == false)
{
  //update the list box 
   DisplayShoes();
}

}

void DisplayShoes()
{
  //create an instance of the shoe collection class 
  Class_Library.clsShoeCollection Shoes = new Class_Library.clsShoeCollection();
  //set the data source to the list of shoes in the collection
  1stShoe.DataSource = Shoe.ShoeList;
  //set the name of the primary key
  1stShoe.DataValueField = "Active";
  //set the data field to display
  1stShoe.DataValueField = "Style";
  //bind the data to the list
  1stShoe.Databind();
}
  


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 ID;
    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of Ids to be deleted from the session object
        ID = Convert.ToInt32(Session["ID"]);
    }

    protected void Btnyes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteID();
        //redirect back to main page 
        Response.Redirect("Default1.aspx");
    }

    void DeleteID()
    {
        //function to delete the selected record 

        //create a new instance of the shoe collection
        clsShoeCollection Shoe = new clsShoeCollection();
        //find the record to delete
        Shoe.ThisShoe.Find(ID);
        //delete the record 
        Shoe.Delete();

    }
}
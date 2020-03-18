using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shoes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of shoes to be processed 
        ID = Convert.ToInt32(Session["ID"]);
        if (IsPostBack == false)
        {
            //populate the list of Id's
            DisplayID();
            //if this is not a new record
            if (ID != -1 )
            {
                //display the current data for the record 
                DisplayID();
            }
        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ID;
        //If a record has been selected from the list 
        if (lstShoes.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ID = Convert.ToInt32(lstShoes.SelectedValue);
            //store the data in the session object
            Session["ID"] = ID;
            //redirect to the delete page 
            Response.Redirect("Delete,aspx");
            {
                else //if no record has been selected

        }
            //display an error 
            lblError.Text = "Plese select a record to delete from the list";
    }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 ID;
        //If a record has been selected from the list
        if (lstShoe.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            ID = Convert.ToInt32(lstShoe.SelectedValue);
            //store the data in the session object 
            Session["ID"] = ID;
            //redirect to the edit page 
            Response.Redirect("Edit.aspx");
        }
        else //if no record has been selected
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicat this is a new record
        Session["ID"] = -1;
        //redirect to the data entry page
        Response.Redirect("Default1.aspx");

    }

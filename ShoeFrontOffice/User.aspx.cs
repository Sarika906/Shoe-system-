using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsStaff AnStaff = new clsStaff();



    }

    protected void btAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["UserID"] = -1;
        //redirect to entry page 
        Response.Redirect("User.aspx");

    }

    //function for adding new records 
    void Add()
    {
        //create an instance of the user collection
        Class_Library.clsUserCollection Userdetails = new Class_Library.clsUserCollection();
        //validate the data on the web form 
        String Error = Userdetails.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text, txtHomeAddress.Text, txtTelephonNumber.Text);
        //if the data is ok then add it to the object 
        if (Error == "")
        {
            //get the data entered by the user
            Userdetails.ThisUser.FirstName = txtFirstName.Text;
            Userdetails.ThisUser.LastName = txtLastName.Text;
            Userdetails.ThisUser.EmailAddress = txtEmailAddress.Text;
            Userdetails.ThisUser.HomeAddress = txtHomeAddress.Text;
            Userdetails.ThisUser.TelephoneNumber = txtTelephoneNumber.Text;
            //add the record
            Userdetails.Add();
        }
        else
        {
            //report an error 
            lblError.Text = "There was a problem with the data entered" + Error;
        }
        }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Add a new record
        Add();
        //all done so redirect to main page
        Response.Redirect("Default1.aspx");
    }

    protected void btnok_Click(object sender, EventArgs e)
    {

    }
}
}public class txtFirstName
{
}

public class txtLastName
{
}

namespace Class_Library
{
    public class clsUserCollection
    {
        public clsUserCollection()
        {
        }
    }
}

public class txtEmailAddress
{
}

public class txtHomeAddress
{
}

public class txtTelephonNumber
{
}

public class txtTelephoneNumber
{
}

public class lblError
{
}
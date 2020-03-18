using ShoeClasses;

namespace ShoeClasses
{
    public class clsShoeCollection
    {
        //private data member for the list
        List<clsShoe> mShoeList = new List<clsShoe>();
        {
        get 
            {
            //return the private data member 
            return mShoeList;
            }
    set
        {
        //set the private data 
        mShoeList =value;
public class mShoeList
    {
    }

    public class mShoeList
    {
    }
}

    }
       //public property for count 
       public int Count
{
    get
    {
        //return the count of list 
        return mShoeList.Count;
    }
    set
    {
        //we shall worry about this later 
    }
    }
}

public class clsShoe
{
    //private data member for the ID property
    private Int32 mID;
}

//public property for the ID
public int ID
{
    get
    {
        //return the private data 
        return mID;
    }
    set
    {
        //set the value of the private data member 
        mID = value;
    }
}
//public data member for Brand
public string Brand
{
    get
    {
        //return the private data
        return mBrand;
    }
    set
    {
        //set the private data 
        mBrand = value;
    }
}
//public data member for Colour
public string Colour
{
    get
    {
        //return the private data
        return mColour;
    }
    set
    {
        //set the private data 
        mColour = value;
    }
}
//public data member for Size
public string Size
{
    get
    {
        //return the private data
        return mSize;
    }
    set
    {
        //set the private data 
        mSize = value;
    }
}
//public data member for Style
public string Style
{
    get
    {
        //return the private data
        return mStyle;
    }
    set
    {
        //set the private data 
        mStyle = value;
    }
}
//public data member for Active
public string Active
{
    get
    {
        //return the private data
        return mActive;
    }
    set
    {
        //set the private data 
        mActive = value;
    }
}
public bool Find (int ID)
{
    //create an instance of the data connection 
    clsDataConnection DB = new clsDataConnection();
    //add the parameter for the ID no to search for 
    DB.AddParameter("@ID", ID);
    //execute the stored procedure
    DB.Execute("sproc_tblShoe_FilterByID");
    //if one record is found 
    if (DB.Count == 1)
    {
        //copy the data from the database to the private data members
        mID = Convert.ToInt32(DB.DataTable.Rows[0]["ID"]);
        mBrand = Convert.ToInt32(DB.DataTable.Rows[0]["Brand"]);
        mColour = Convert.ToInt32(DB.DataTable.Rows[0]["Colour"]);
        mSize = Convert.ToInt32(DB.DataTable.Rows[0]["Size"]);
        mStyle = Convert.ToInt32(DB.DataTable.Rows[0]["Style"]);
        mActive = Convert.ToInt32(DB.DataTable.Rows[0]["Active"]);
        //return that everything worked OK
        return true;
    }
    //if no record was found 
    else
    {
        //return the false indicating the problem 
        return false; 
    }
}
}
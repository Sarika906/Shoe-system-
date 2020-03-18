using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeClasses; 
namespace Shoe_testing
{
    /// <summary>
    /// Summary description for Tstshoecollection2
    /// </summary>
    [TestClass]
    public class Tstshoecollection2
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsShoeCollection AllShoe = new clsShoeCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllShoe);
        }
        [TestMethod]
        public void ShoeListOK()
        {
            //create an instance of the class we want to create 
            clsShoeCollection AllShoe = new clsShoeCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of object
            List<clsShoe> TestList = new List<clsShoe>();
            //add an item to the list
            //create the item of test data 
            clsShoe TestItem = new clsShoe();
            //set its properties
            TestItem.Active = true;
            TestItem.Brand = "some brand";
            TestItem.Colour = "some colour";
            TestItem.Size = 1;
            TestItem.Style = "some style";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllShoe.ShoeList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllShoe / ShoeList, TestList);

           [TestMethod]
           public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsShoeCollection AllShoe = new clsShoeCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property 
            AllShoe.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllShoe.Count, SomeCount); 
      }
          [TestMethod]
          public void ThisShoeOK()
        {
            //create an instance of the class we want to create 
            clsShoeCollection AllShoe = new clsShoeCollection();
            //create some test data to assign to the property
            clsShoe TestShoe = new clsShoe();
            //set the properties of the test object 
            TestItem.Active = true;
            TestItem.Brand = "some brand";
            TestItem.Colour = "some colour";
            TestItem.Size = 1;
            TestItem.Style = "some style";
            //assign the data to the property
            //Test to see that the two values are the same
            Assert.AreEqual(AllShoe / ShoeList, TestList);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create 
            clsShoeCollection AllShoe = new clsShoeCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsShoe> TestList = new List<clsShoe>();
            //Add an item to the list
            //create the item of test data 
            clsShoe TestItem = new clsShoe();
            //set its properties 
            TestItem.Active = true;
            TestItem.Brand = "some brand";
            TestItem.Colour = "some colour";
            TestItem.Size = 1;
            TestItem.Style = "some style";
            //add the item to the test list
            TestList.Add(TestItem)
            //assign the data to the property 
            AllShoe.ShoeList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllShoe.Count, SomeCount);
        }


    }
    }
           //constructor for the class 
           public clsShoeCollection()
{
    //create the items of test data 
    clsShoe TestItem = new clsShoe();
    //set its properties 
    TestItem.Active = true;
    TestItem.Brand = "some brand";
    TestItem.Colour = "some colour";
    TestItem.Size = 1;
    TestItem.Style = "some style";
    //add the item to the test list
    mShoeList.Add(TestItem);
    //re initialise the object for some new data 
    TestItem = new clsShoe();
    //set its properties 
    TestItem.Active = true;
    TestItem.Brand = "some brand";
    TestItem.Colour = "some colour";
    TestItem.Size = 1;
    TestItem.Style = "some style";
    //add the item to the test list 
    mShoeList.Add(TestItem);
}

//constructor for the class 
public clsShoeCollection()
{
    //var for the index
    Int32 Index = 0;
    //var to store the record count
    Int32 RecordCount = 0;
    //object for data connection
    clsDataConnection DB = new clsDataConnection();
    //execute the stored procedure
    DB.Execute("sproc_tblShoe_SelectAll");
    //get the count of records
    RecordCount = DB.Count;
    //while there are records to process 
    while (Index < RecordCount)
    {
        //create a blank 
        clsShoeCollection AShoe = new clsShoeCollection();
        //read the fields from the current records
        AShoe.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
        AShoe.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand");
        AShoe.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour");
        AShoe.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size");
        AShoe.Style = Convert.ToString(DB.DataTable.Rows[Index]["Style");
        //add the record to the private data member
        mShoeList.Add(AShoe);
        //Point at the next record
        Index++;
    }

}
       clsShoeCollection AllShoe = new clsShoeCollection();
       AllShoe.ThisShoe.Find(3);
       AllShoe.Delete();

       clsShoeCollection AllShoe = new clsShoeCollection();
       AllShoe.ThisShoe.Find(3);
       AllShoe.ThisShoe.Brand = "Nike";
       AllShoe.Update();

       clsShoeCollection AllShoe = new clsShoeCollection();
       AllShoe.ThisShoe.Active = true;
       AllShoe.ThisShoe.Id = 1;
       AllShoe.ThisShoe.Active = "Yes";
       AllShoe.ThisShoe.Brand = "Nike";
       AllShoe.ThisShoe.Colour = "White";
       AllShoe.ThisShoe.Size = "five";
       AllShoe.ThisShoe.Style = "Trainer";
       AllShoe.Add();

    [TestMethod]
    public void AddMethodOK()
{
    //create an instance of the class we want to create 
    clsShoeCollection AllShoe = new clsShoeCollection();
    //create the item of test data
    clsShoe TestItem = new clsShoe();
    //var to store the primary key 
    Int32 Id = 0;
    //set its properties
    TestItem.Active = true;
    TestItem.Brand = "some brand";
    TestItem.Colour = "some colour";
    TestItem.Size = 1;
    TestItem.Style = "some style";
    //set ThisShoe to the test data 
    AllShoe.ThisShoe = TestItem;
    //add the record
    Id = AllShoe.Add();
    //set the primary key for the data 
    TestItem.Id = Id;
    //find the record
    AllShoe.ThisShoe.Find(Id);
    //test to see that the two values are the same
    Assert.AreEqual(AllShoe.ThisShoe, TestItem);
}

public int Add()
    //adds a new record to the database based on the values of thisShoe
    //connect to the database
    clsDataConnection DB = new clsDataConnection();
    //set the parameters for the stored procedure
    DB.AddParameter("@Id", mThisShoe.Id);
    DB.AddParameter("@Active", mThisShoe.Active);
    DB.AddParameter("@Brand", mThisShoe.Brand);
    DB.AddParameter("@Colour", mThisShoe.Colour);
    DB.AddParameter("@Size", mThisShoe.Size);
    DB.AddParameter("@Style", mThisShoe.Style);
    //execute the query returning the primary key value
    return DB.Execute("sproc_tblShoe_Insert");


    [TestMethod]
    public void DeleteMethodOK()
{
    //create an instance of the class we want to create 
    clsShoeCollection AllShoe = new clsShoeCollection();
    //create the item of test data 
    clsShoe Testitem = new clsShoe();
    //var to store the primary key 
    Int32 PrimaryKey = 0;
    //set its properties
    Testitem.Active = true;
    Testitem.Brand = "some brand";
    Testitem.Colour = "some colour";
    Testitem.Size = 1;
    Testitem.Style = "some style";
    //set ThisShoe to the test data 
    AllShoe.ThisShoe = Testitem;
    //add the record
    PrimaryKey = AllShoe.Add();
    //set the primary key of the test data 
    Testitem.Id = PrimaryKey;
    //find the record
    AllShoe.ThisShoe.Find(PrimaryKey);
    //delete the record
    AllShoe.Delete();
    //now find the record
    Boolean Found = AllShoe.ThisShoe.Find(PrimaryKey);
    //test to see that the record was not found 
    Assert.IsFalse(Found);

}

public void Delete()
{
    //deletes the record pointed to by thisshoe
    //connect to the database
    clsDataConnection DB = new clsDataConnection();
    //set the parameters for the stored procedure 
    DB.AddParameter("@ID", mThisShoe.ID);
    //execute the stored procedure 
    DB.Execute("sproc_tblShoe_Delete");
}

[TestMethod]
public void UpdateMethodOK()
{
    //create an instance of the class we want to create
    clsShoeCollection AllShoe = new clsShoeCollection();
    //create the item of test data 
    clsShoe TestItem = new clsShoe();
    //var to store the primary key 
    Int32 PrimaryKey = 0;
    //set its properties
    TestItem.Active = true;
    TestItem.Brand = "some brand";
    TestItem.Colour = "some colour";
    TestItem.Size = 1;
    TestItem.Style = "some style";
    //set ThisShoe to the test data 
    AllShoe.ThisShoe = TestItem;
    //add the record
    PrimaryKey = AllShoe.Add();
    //set the primary key of the test data 
    TestItem.ThisShoe = PrimaryKey;
    //modify the test data 
    TestItem.Active = false;
    TestItem.Brand = "some brand";
    TestItem.Colour = "some colour";
    TestItem.Size = 3;
    TestItem.Style = "some style";
    //set the record based on the new test data 
    AllShoe.ThisShoe = TestItem;
    //update the record
    AllShoe.Update();
    //find the record
    AllShoe.ThisShoe.Find(PrimaryKey);
    //test to see ThisShoe matches the test data 
    Assert.AreEqual(AllShoe.ThisShoe, TestItem);

}

public void Update()
{
    //update an existing record based on the values of thishoe
    //connect to the database
    clsDataConnection DB = new clsDataConnection();
    //set the parameters for the stored procedure 
    DB.AddParameter("@ID", mThisShoe.Id);
    DB.AddParameter("@Active", mThisShoe.Active);
    DB.AddParameter("@Brand", mThisShoe.Brand);
    DB.AddParameter("@Colour", mThisShoe.Colour);
    DB.AddParameter("@Size", mThisShoe.Size);
    DB.AddParameter("@Style", mThisShoe.Style);
    //execure the stored procedure
    DB.Execute("sproc_tblShoe_Update")



}

//function for updating records
void Update()
{
    //create an instance of the shoe book
    Class_Library.clsShoeCollection Shoe = new Class_Library.clsShoeCollection();
    //validate the data on the web form 
    String Error = Shoe.ThisShoe.Valid(txtId.Text, txtActive.Text, txtBrand.Text, txtColour.Text, txtSize.Text, TxtStyle.Text);
    //if the data is OK then add it to the object 
    if (Error == "")
    {
        //find the record to update 
        Shoe.ThisShoe.Find(Id);
        //get the data entered by the user 
        Shoe.ThisShoe.Active = chkActive.Checked;
        Shoe.ThisShoe.Id = txtID.Text;
        Shoe.ThisShoe.Brand = txtBrand.Text;
        Shoe.ThisShoe.Colour = txtColour.Text;
        Shoe.ThisShoe.Size = txtSize.Text;
        Shoe.ThisShoe.Style = txtStyle.Text;
        //update the record
        Shoe.Update();
        //all done so redirect back to main page 
        Response.Redirect("Default1.aspx");
    }
    else
    {
        //report an error 
        lblError.Text = "There were problems with the data entered" + Error;
    }
}

void DisplayShoes()
{
    //create an instance of the shoe book
    clsShoeCollection Shoe = new clsShoeCollection();
    //find the record to update 
    Shoe.ThisShoe.Find(ID);
    //display the data for this record 
    txtBrand.Text = Shoe.ThisShoe.Brand;
    txtColour.Text = Shoe.ThisShoe.Colour;
    txtSize.Text = Shoe.ThisShoe.Size;
    txtStyle.Text = Shoe.ThisShoe.Style;
    chkActive.Checked = Shoe.ThisShoe.Active;

}

[TestMethod]
public void ReportByIDMethodOk(string ID)
{
    //filters the records based on full or partial code 
    //create an instance of the class containing unfiltered results
    clsShoeCollection AllShoe = new clsShoeCollection();
    //create an instance of the filtered data
    clsShoeCollection FilteredID = new clsShoeCollection();
    //apply a blank string (should return all records)
    FilteredID.ReportByID("");
    //test to see that the two values are the same 
    Assert.AreEqual(AllShoe.Count, FilteredID.Count);


}

[TestMethod]

public void ReportByIDMethodNoneFound ()
{
    //create an instance of the filtered records 
    clsShoeCollection FilteredID = new clsShoeCollection();
    //apply a ID that doesnt exist
    FilteredID.ReportByID("xxx xxx xxx");
    //test to see that there are no records
    Assert.AreEqual(0, FilteredID.Count);
}

[TestMethod]
public void ReportByIDMethodOk(string ID)
{
    //filters the records based on full or partial code 
    //connect to the database
    clsDataConnection DB = new clsDataConnection();
    //send the ID parameter to the database
    DB.AddParameter("@ID", ID);
    //execute the stored procedure 
    DB.Execute("sproc_tblShoe_FilterByID");
    //populate the array list with the data table 
    PopulateArray(DB);
}

void PopulateArray(clsDataConnection DB)
{
    //populates the array list based on the data table in the parameter DB
    //var for the index
    Int32 Index = 0;
    //var to store the record count
    Int32 RecordCount;
    //get the count of records
    RecordCount = DB.Count;
    //clear the private array list
    mShoeList = new List<clsShoe>();
    //while there are records to process
    while (Index < RecordCount)
    {
        //create a blank shoe
        clsShoe AShoe = new clsShoe();
        //read in the fields from the current records 
        AShoe.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
        AShoe.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["ID"]);
        AShoe.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
        AShoe.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
        AShoe.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
        AShoe.Style = Convert.ToString(DB.DataTable.Rows[Index]["Style"]);
        //add the record to the private data member
        mShoeList.Add(AShoe);
        //point at the next record
        Index++;

    }
}
[TestMethod]
public void ReportByIDTestDataFound()
{
    //create an instance of the filtered data 
    clsShoeCollection FilteredID = new clsShoeCollection();
    //var to store the outcome 
    Boolean OK = true;
    //apply an ID that doesnt exist 
    FilteredID.ReportByID("yyyyyyy");
    //check that the correct number of records are found
    if (FilteredID.Count == 2)
    {
        //check that the first record is ID 36
        if (FilteredID.Shoelist[0].ID !== 36)
        {
            OK = false;
        }
        //check that the first record is ID 37
        if (FilteredID.Shoelist[1].ID !== 37)
        {
            OK = false;
        }
    }
    else
    {
        OK = false;
    }
    //test to see that there are no records
    Assert.IsTrue(OK);
    }
}

[TestMethod]
public bool Find(int ID)
{
    //set the private data member to the test data value 
    mID = 21;
    //always return a true value 
    return true;
    //create an instane of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the validation 
    Boolean Found = false;
    //create some test data to use with the method
    Int32 ID = 1;
    //invoke the method
    Found = AShoe.Find(ID);
    //test to see that result is correct
    Assert.IsTrue(Found);
}

[TestMethod]
public void TestIDNoFound()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the search 
    Boolean Found = false;
    //boolean variable to record if the data is OK 
    Boolean OK = true;
    //create some test data to use with the method 
    Int32 ID = 2;
    //invoke the method
    Found = AShoe.Find(ID);
    //check the ID no 
    if (AShoe.ID !== 100)
    {
        OK = false;
    }
    //test to see that the result is correct 
    Assert.IsTrue(OK);
}

[TestMethod]
public void BrandPropertyOK()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //create some test data assigned to this property
    String TestData = "Gucci";
    //assign the data to the property
    AShoe.Brand = TestData;
    //test to see that the two values are the same
    Assert.AreEqual(AShoe.Brand, TestData);

}
[TestMethod]
public void ColourPropertyOK()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //create some test data assigned to this property
    String TestData = "Red";
    //assign the data to the property
    AShoe.Colour = TestData;
    //test to see that the two values are the same
    Assert.AreEqual(AShoe.Colour, TestData);
}
[TestMethod]
public void SizePropertyOK()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //create some test data assigned to this property
    Int32 TestData = "6";
    //assign the data to the property
    AShoe.Size = TestData;
    //test to see that the two values are the same
    Assert.AreEqual(AShoe.Size, TestData);
}
[TestMethod]
public void StylePropertyOK()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //create some test data assigned to this property
    String TestData = "Heel";
    //assign the data to the property
    AShoe.Style = TestData;
    //test to see that the two values are the same
    Assert.AreEqual(AShoe.Style, TestData);
}
[TestMethod]
public void TestBrandNoFound()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the search 
    Boolean Found = false;
    //boolean variable to record if the data is OK 
    Boolean OK = true;
    //create some test data to use with the method 
    string Brand = "Gucci";
    //invoke the method
    Found = AShoe.Find(Brand);
    //check the Brand 
    if (AShoe.Brand!== ajsjsdjd)
    {
        OK = false;
    }
    //test to see that the result is correct 
    Assert.IsTrue(OK);
}
[TestMethod]
public void TestColourNoFound()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the search 
    Boolean Found = false;
    //boolean variable to record if the data is OK 
    Boolean OK = true;
    //create some test data to use with the method 
    string Colour = "Pink";
    //invoke the method
    Found = AShoe.Find(Colour);
    //check the colour 
    if (AShoe.Colour !== white)
    {
        OK = false;
    }
    //test to see that the result is correct 
    Assert.IsTrue(OK);
}
[TestMethod]
public void TestSizeNoFound()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the search 
    Boolean Found = false;
    //boolean variable to record if the data is OK 
    Boolean OK = true;
    //create some test data to use with the method 
    Int32 ID = 2;
    //invoke the method
    Found = AShoe.Find(ID);
    //check the ID no 
    if (AShoe.ID !== 100)
    {
        OK = false;
    }
    //test to see that the result is correct 
    Assert.IsTrue(OK);
}
[TestMethod]
public void TestStyleNoFound()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the search 
    Boolean Found = false;
    //boolean variable to record if the data is OK 
    Boolean OK = true;
    //create some test data to use with the method 
    string ID = "Heel";
    //invoke the method
    Found = AShoe.Find(Style);
    //check the style
    if (AShoe.Style !== red)
    {
        OK = false;
    }
    //test to see that the result is correct 
    Assert.IsTrue(OK);
}
[TestMethod]
public bool BrandFound()
{
    //create an instane of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the validation 
    Boolean Found = false;
    //create some test data to use with the method
    string Brand = "Dior";
    //invoke the method
    Found = AShoe.Find(Brand);
    //test to see that result is correct
    Assert.IsTrue(Found);
}
[TestMethod]
public bool ColorFound()
{
    //create an instane of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the validation 
    Boolean Found = false;
    //create some test data to use with the method
    string Colour = 1;
    //invoke the method
    Found = AShoe.Find(Colour);
    //test to see that result is correct
    Assert.IsTrue(Found);
}
[TestMethod]
public bool SizeFound()
{
    //create an instane of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the validation 
    Boolean Found = false;
    //create some test data to use with the method
    Int32 Size = 1;
    //invoke the method
    Found = AShoe.Find(Size);
    //test to see that result is correct
    Assert.IsTrue(Found);
}
[TestMethod]
public bool StyleFound()
{
    //create an instane of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //boolean variable to store the result of the validation 
    Boolean Found = false;
    //create some test data to use with the method
    string Style = "boots";
    //invoke the method
    Found = AShoe.Find(Style);
    //test to see that result is correct
    Assert.IsTrue(Found);
}
[TestMethod]
public void BrandMinLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    string Brand = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");


  
}
[TestMethod]
public void Brand()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Brand = "a"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void BrandPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Brand = "aa"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void BrandMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void BrandMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void BrandMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

public string Valid (string Colour, string Size, String Style, string ID, string Active)
{
    //create a string variable to store the error message 
    String Error = "";
    //if the Brand is left blank 
    if (Brand.length ==0)
    {
        //record the error 
        Error = Error + "The brand name must not be left blank";
    }
    //if the brand field is greater than 51 
    if (Brand.length > 51)
    {
        //record the error 
        Error = Error + "The brand name must be less than 51 characters";
    }
    //return any error messages 
    return Error;

}
[TestMethod]
public void ColourLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    string Colour = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void Colour()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Colour = "a"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void ColourPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Colour = "aa"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void ColourMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void ColourMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void ColourMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}


[TestMethod]
public void SizeLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    Int32 Size = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void Size()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 Size = "1"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void SizePlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Size = "12"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void SizeMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 Size = "11111111111111111111111"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void SizeMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 Size = "111111111"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void SizeMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Size = "11111111111111111111111111"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void StyleLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    Int32 Style = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void Style()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 Style = "a"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void StylePlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Size = "aa"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void StyleMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 Style = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void StyleMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 Style = "aaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void StyleMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string Style = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}
}

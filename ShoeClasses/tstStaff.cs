using ShoeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeClasses
{
    class tstStaff
    {
    }
}
[TestMethod]
public void InstanceOK()
{
    //Create an instance of the class we want to create
    clsStaff AnStaff = new clsStaff();
    //test to see that it exists
    Assert.IsNotNull(AnStaff);

}

[TestMethod]
public void ActivePropertyOK()
    //create an instance of the class we want to create 
    clsStaff AnStaff = new clsStaff();
//create some test data to assign to the property
Boolean Testdata = true;
//assign the data to the property
AnStaff.Active = TestData;
//test to see that the two values are the same 
Assert.AreEqual(AnStaff.Active, TestData); 

[TestMethod]
public void DateAddedPropertyOK()
{
    //create an instance of the class we want to create 
    clsStaff AnStaff = new clsStaff();
    //create some test data to assign to the property
    DateTime TestData = DateTime.Now.Date;
    //assign the data to the property
    AnStaff.DateAdded = TestData;
    //test to see that the two values are the same 
    Assert.AreEqual(AnStaff.DateAdded, TestData);

}
[TestMethod]
public void FirstNameMinLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    string FirstName = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");



}
[TestMethod]
public void FirstName()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string FirstName = "a"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void FirstNamePlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string FirstName = "aa"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void FirstNameMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void FirstNameMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void FirstNameMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void LastNameMinLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    string LastName = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");



}
[TestMethod]
public void LastName()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string LastName = "a"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void LastNamePlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string LastName = "aa"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void LastNameMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void LastNameMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void LastNameMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void EmailAddressMinLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    string EmailAddress = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");



}
[TestMethod]
public void EmailAddress()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string EmailAddress = "a"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void EmailAddressPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string EmailAddress = "aa"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void EmailAddressMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void EmailAddressMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void EmailAddressMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void HomeAddressMinLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    string HomeAddress = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");



}
[TestMethod]
public void HomeAddress()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string HomeAddress = "a"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void HomeAddress()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string HomeAddress = "aa"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void HomeAddress()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string HomeAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void HomeAddressMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string HomeAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void HomeAddressMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string HomeAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void TelephoneNumberLessOne()
{
    //create an instance of the class we want to create 
    clsShoe AShoe = new clsShoe();
    //string variable to store any error messages 
    String Error = "";
    //Create some test data to pass the method
    Int32 TelephoneNumberLessOne = ""; //this should trigger an error 
    //invoke the method 
    Error.AShoe.Valid
    //test to see that the result is correct
    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void TelephoneNumberLessOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 TelephoneNumberLessOne = "1"; //this should be ok
    //test to see that the result is correct
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void TelephoneNumberLessOnePlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string TelephoneNumberLessOne = "12"; //this should be ok
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void TelephoneNumberLessOneMax()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 TelephoneNumberLessOne = "11111111111111111111111"; //this should be ok
    Assert.AreEqual(Error, "");

}

[TestMethod]
public void TelephoneNumberLessOneMid()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    Int32 TelephoneNumberLessOne = "111111111"; //this should be ok
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void TelephoneNumberLessOneMaxPlusOne()
{
    //create an instance of the class we want to create
    clsShoe AShoe = new clsShoe();
    //string variable to store any error message
    String Error = "";
    //create some test data to pass to the method
    string TelephoneNumberLessOne = "11111111111111111111111111"; //this should be ok
    Assert.AreEqual(Error, "");
}






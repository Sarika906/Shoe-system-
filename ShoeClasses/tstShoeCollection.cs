using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeClasses
{
    [TestClass]
    public class tstShoeCollection
    {
        //private data member for the list 
        List <clsShoeCollection> mShoeList = new List<clsShoeCollection>
        //private data member thisshoe
        clsShoe mThisShoe = new clsShoe();

        //public property for ThisShoe 
        public clsShoeCollection ThisShoe
        {
            get
            {
                //return the private data 
                return mShoeList;
            }
            set
            {
                //set the private data 
                mThisShoe = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisShoe
            //set the primary key value for the new record 
            mThisShoe.Id = 1;
            //return the primary key of the new record
            return mThisShoe.Id;
        }

        [TestMethod]
        public void TestMethod1()
        {

        }


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
            List<clsShoeCollection> TestList = new List<clsShoeCollection>();
            //add an item to the list
            //create the item of test data 
            clsShoeCollection TestItem = new clsShoeCollection();
            //set its properties
            TestItem.Active = true;
            TestItem.Brand = "some brand";
            TestItem.Colour = "some colour";
            TestItem.Size = 1;
            TestItem.
    

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

    }
}

using AddressBook_ADO.NET;

namespace AddressBookADO.NET_TEST
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Updates the contact details. UC17
        /// </summary>
        /// <returns></returns>
        public AddressBookContactDetails UpdateContactDetails()
        {
            //passing data for updating
            AddressBookContactDetails contactDetails = new AddressBookContactDetails();
            contactDetails.firstName = "vetri";
            contactDetails.lastName = "Velan";
            contactDetails.address = "Anbu Nagar";
            contactDetails.city = "hosur";
            contactDetails.state = "tamilnadu";
            contactDetails.zip = 635109;
            contactDetails.phoneNo = 8883380120;
            contactDetails.eMail = "vetrivel.kce@gmail.com";
            contactDetails.addressBookName = "B";
            //passing data to update method in address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            bool result = addressBookOperations.UpdateContactDetailsInDataBase(contactDetails);
            Console.WriteLine(result);
            return contactDetails;
        }
        [TestMethod]
        public void CheckingIfContactDetailsAreGettingUpdated()
        {
            //calling update contact details
            //getting actual data
            AddressBookContactDetails actual = UpdateContactDetails();
            AddressBookContactDetails contactDetails = new AddressBookContactDetails();
            //passing data to get updated contact details
            contactDetails.firstName = "vetri";
            contactDetails.lastName = "velan";
            contactDetails.addressBookName = "B";
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting expected data from address book operations -getting updated details
            AddressBookContactDetails expected = addressBookOperations.GettingUpdatedDetails(contactDetails);
            //assert
            Assert.AreEqual(expected, actual);


        }

        /// <summary>
        /// checking that we are getting the contacts based on the time range.
        /// </summary>
        [TestMethod]
        public void CheckingForGettingContactDetailsInParticularTimeRange()
        {
            //creating list for expected output
            List<AddressBookContactDetails> contactDetailsExpected = new List<AddressBookContactDetails>();
            //adding data
            contactDetailsExpected.Add(new AddressBookContactDetails { firstName = "vetri", lastName = "Velan", address = "Anbu Nagar", city = "hosur", state = "tamilnadu", zip = 635109, phoneNo = 8883380120, eMail = "vetrivel.kce@gmail.com" });
            //instatiating object for address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting actual contact list from address book operations-getting contact details from particular date range
            List<AddressBookContactDetails> contactDetailsActual = addressBookOperations.GetAllContactDetailsForParticularDateRange();
            //assert for comparing list
            CollectionAssert.AreEqual(contactDetailsActual, contactDetailsExpected);
        }


        /// <summary>
        /// Checkings for getting contact details for particular state. UC19
        /// </summary>
        [TestMethod]
        public void CheckingForGettingContactDetailsForParticularState()
        {
            //creating list for expected output
            List<AddressBookContactDetails> contactDetailsExpected = new List<AddressBookContactDetails>();
            //adding data
            contactDetailsExpected.Add(new AddressBookContactDetails { firstName = "chandru", lastName = "kalamath", address = "Chanda Nagar", city = "gadag", state = "banglore", zip = 734251, phoneNo = 9597959938, eMail = "chandru1595@gmail.com" });
            //instatiating object for address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting actual contact list from address book operations-getting contact details from particular date range
            List<AddressBookContactDetails> contactDetailsActual = addressBookOperations.GetAllContactDetailsWithConditions();
            //assert for comparing list
            CollectionAssert.AreEqual(contactDetailsActual, contactDetailsExpected);
        }
        /// <summary>
        /// Checkings for getting contact details for particular city. UC19
        /// </summary>
        [TestMethod]
        public void CheckingForGettingContactDetailsForParticularCity()
        {
            //creating list for expected output
            List<AddressBookContactDetails> contactDetailsExpected = new List<AddressBookContactDetails>();
            //adding data
            contactDetailsExpected.Add(new AddressBookContactDetails { firstName = "vetri", lastName = "Velan", address = "Anbu Nagar", city = "hosur", state = "tamilnadu", zip = 635109, phoneNo = 8883380102, eMail = "vetrivel.kce@gmail.com" });

            //instatiating object for address book operations
            AddressBookOperations addressBookOperations = new AddressBookOperations();
            //getting actual contact list from address book operations-getting contact details from particular date range
            List<AddressBookContactDetails> contactDetailsActual = addressBookOperations.GetAllContactDetailsWithConditions();
            //assert for comparing list
            CollectionAssert.AreEqual(contactDetailsActual, contactDetailsExpected);
        }
    }
}

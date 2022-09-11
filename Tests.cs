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
            contactDetails.zip = 125121;
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
    }
}

namespace AddressBookSystem
{
    class Program
    {
        //creating list of contact
        public static List<Contact> contactList = new List<Contact>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem.");

            //ability to creating contacts
            Contact contact1 = new Contact();
            contact1.firstName = "Vetri";
            contact1.lastName = "velan";
            contact1.address = "hosur";
            contact1.phone = 1234567890;
            contact1.city = "banglore";
            contact1.state = "banglore";
            contact1.zipcode = 413515;
            contactList.Add(contact1);

        }
    }
}

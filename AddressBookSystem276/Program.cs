namespace AddressBookSystem276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem");
            Console.WriteLine("\n1:Createcontact\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1-Createcontact
                case 1:
                    CreateContact();
                    break;
                default:
                    Console.WriteLine("Choose from given options only");
                    break;
            }
        }
        public static void CreateContact()
        {
            //reading data and storing in set of method/properties
            Console.WriteLine("Enter the First name: ");
            string firstName = Console.ReadLine();
            //LastName
            Console.WriteLine("Enter the LastName: ");
            string lastName = Console.ReadLine();
            //Address
            Console.WriteLine("Enter the Address: ");
            string address = Console.ReadLine();
            //City
            Console.WriteLine("Enter city Name: ");
            string city = Console.ReadLine();
            //State
            Console.WriteLine("Enter State Name: ");
            string state = Console.ReadLine();
            //ZipCode
            Console.WriteLine("Enter the Zipcode: ");
            int zipCode = Convert.ToInt32(Console.ReadLine());
            //PhoneNumber
            Console.WriteLine("Enter the Phone Number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            //EmailId
            Console.WriteLine("Enter the Email id: ");
            string emailId = Console.ReadLine();
        }
    }
}
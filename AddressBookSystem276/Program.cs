namespace AddressBookSystem276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem");
            Console.WriteLine("\n1:Createcontact\n2:AddnewContact\n3:EditContacts");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1 Createcontacts
                case 1:
                    AddressBook myObj = new AddressBook();
                    myObj.CreateContacts();
                    break;
                //UC2 Addanewcontacts
                case 2:
                    AddressBook myObj1 = new AddressBook();
                    myObj1.CreateContacts();
                    break;
                //UC3 Exit existing contact
                case 3:
                    AddressBook myObj2 = new AddressBook();
                    myObj2.EditContact();
                    break;
                default:
                    Console.WriteLine("Choose from given option only");
                    break;

            }
        }
    }
}
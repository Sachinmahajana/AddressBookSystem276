namespace AddressBookSystem276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem");
            Console.WriteLine("\n1:Createcontact\n2:AddnewContact\n3:EditContacts\n4:Deletecontacts\n5:Displaycontacts\n6:AddMultipleContacts");
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
                    myObj1.DisplayContact();
                    break;
                //UC3 Exit existing contact
                case 3:
                    AddressBook myObj2 = new AddressBook();
                    myObj2.EditContact();
                    break;
                //UC4 Deletecontacts
                case 4:
                    AddressBook myObj3 = new AddressBook();
                    myObj3.DeleteContact();
                    break;
                case 5:
                    AddressBook myObj4 = new AddressBook();
                    myObj4.DisplayContact();
                    break;
                //UC5 AddMultiplecontacts
                case 6:
                    AddressBook myObj5 = new AddressBook();
                    myObj5.CreateContacts();
                    myObj5.DisplayContact();
                    break;
                default:
                    Console.WriteLine("Choose from given option only");
                    break;

            }
        }
    }
}
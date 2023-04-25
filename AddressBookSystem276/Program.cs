namespace AddressBookSystem276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem");
            Console.WriteLine("\n1:Createcontact\n2:AddnewContact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1 Createcontacts
                case 1:
                    Addressbook.CreateContacts();
                    break;
                //UC2 Addanewcontacts
                case 2:
                    Addressbook.CreateContacts();
                    break;
                default:
                    Console.WriteLine("Choose from given option only");
                    break;
                     



            }
        }
    }
}
using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter the name of the company:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter the address of the company:");
        string address = Console.ReadLine();
        Console.WriteLine("Enter the phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter the fax number:");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Enter the web site Address: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter the first name of the manager:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter the last name of the manager: ");
        string managerLastName = Console.ReadLine();
        string managerFullName = managerFirstName + " " + managerLastName;
        Console.WriteLine("Enter the age of the manager:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter the phone number of the manager:");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine("Company Information");
        Console.WriteLine("Companu name: {0}", companyName);
        Console.WriteLine("Company Address: {0}", address);
        Console.WriteLine("Company phone number: {0}", phoneNumber);
        Console.WriteLine("Company fax number: {0}", faxNumber);
        Console.WriteLine("Company Web site: {0}", webSite);
        Console.WriteLine("Company manager: {0}", managerFullName);
        Console.WriteLine("Manager information");
        Console.WriteLine("Manager first name: {0}", managerFirstName);
        Console.WriteLine("Manager last name: {0}", managerLastName);
        Console.WriteLine("Manager age {0}", age);
        Console.WriteLine("Manager phone number: {0}", managerPhoneNumber);
    }
}

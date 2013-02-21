using System;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("Enter your first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your midle name");
        string midleName = Console.ReadLine();
        Console.WriteLine("Ënter your last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your amount of money");
        decimal amount = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter your bank name");
        string bankName = Console.ReadLine();
        Console.WriteLine("Enter your IBAN");
        string iban = Console.ReadLine();
        Console.WriteLine("Enter your BIC code");
        string bic = Console.ReadLine();
        Console.WriteLine("Enter your first credit card number");
        long firstCardNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second credit card number");
        long secondCardNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter your third credit card number");
        long thirdCardNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Your Bank Account information:");
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Middle Name: {0}", midleName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Amount of money: {0}", amount);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("BIC: {0}", bic);
        Console.WriteLine("First credit card number: {0}", firstCardNumber);
        Console.WriteLine("Second credit card number: {0}", secondCardNumber);
        Console.WriteLine("Third credit card number: {0}", thirdCardNumber);
    }
}
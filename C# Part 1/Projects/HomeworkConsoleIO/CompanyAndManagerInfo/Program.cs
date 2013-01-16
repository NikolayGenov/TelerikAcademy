using System;

class CompanyAndManagerInfo
{
    static void Main()
    {
        Console.WriteLine("Company Name : ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company Address : ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Company Website : ");
        string companyWebsite = Console.ReadLine();
        Console.WriteLine("Company Phone Number : ");
        long companyPhoneNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Company Fax Number : ");
        long companyFaxNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Manager First name : ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Manager Last name : ");
        string managerLastName = Console.ReadLine();
        string companyManager = managerFirstName + " " + managerLastName;
        Console.WriteLine("Manager Age : ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Manager Phone Number : ");
        long managerPhoneNumber = long.Parse(Console.ReadLine());
        //Print all the info about the company and the manager
        Console.WriteLine(@"The company '{0}' has address : {1}
You can also visit their website:{2}
Another option is to call their Phone number:{3} 
or send them a fax:{4}
The Manager is {5} and their age is {6}
You can contact the manager by calling : {7}",
companyName, companyAddress, companyWebsite,
companyPhoneNumber, companyFaxNumber, companyManager,
managerAge, managerPhoneNumber);


    }
}


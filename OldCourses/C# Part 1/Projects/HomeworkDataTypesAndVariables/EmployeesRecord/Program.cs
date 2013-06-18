using System;

class EmployeesRecord
{
    static void Main()
    {
        string firstName;
        string familyName;
        byte age ;
        char gender;
        int IDNumber;
        int employeeNumber;
       //Example
        firstName = "Ivan";
        familyName = "Ivanov";
        age = 50;
        gender = 'M';
        IDNumber = 23423445;
        employeeNumber = 27563560;
        Console.WriteLine(@"First name: {0}
Family Name : {1}
Age : {2}
Gender : {3}
ID Number : {4}
Employee Number : {5}",familyName,familyName,age,gender,IDNumber,employeeNumber);

    }
}


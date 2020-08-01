using System;

namespace _5_6_Lab_If_Statement
{
    class Program
    {
        public struct Cust // Structure for customer data
        {
            public int custID;
            public string firstName;
            public string lastName;
            public int custAge;
            public bool premStatus;
        }

            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
                // Customer data for each customer

                Cust cust_1 = new Cust()
                {
                    custID = 1,
                    firstName = "John",
                    lastName = "Public",
                    custAge = 18,
                    premStatus = true //contradictory due to age, but member for testing pruposes
                };
                Cust cust_2 = new Cust()
                {
                    custID = 2,
                    firstName = "Bette",
                    lastName = "Midler",
                    custAge = 21,
                    premStatus = false
                };
                Cust cust_3 = new Cust()
                {
                    custID = 3,
                    firstName = "Robert",
                    lastName = "Frost",
                    custAge = 41,
                    premStatus = true
                };

                //Create an array of customer data by customer
                Cust[] custList = {cust_1, cust_2, cust_3};

                //Process customers for age and membership status
                for (int i = 0; i < custList.Length; i++)
                {
                    if (custList[i].custAge < 21)
                    {
                        Console.WriteLine(custList[i].firstName + " " + custList[i].lastName + " is underage.");
                        if (custList[i].premStatus = true)
                        {
                            Console.WriteLine(custList[i].firstName +" " + custList[i].lastName + " has a Premium membership - need to cancel!");
                        }
                    }

                    if (custList[i].custAge >= 21 & custList[i].premStatus == false)
                    {
                        Console.WriteLine(custList[i].firstName + " " + custList[i].lastName + " is of legal age");
                        Console.WriteLine("Would " + custList[i].firstName + " " + custList[i].lastName + " like to purchase a Premium membership?");
                    }

                    if (custList[i].custAge >= 21 & custList[i].premStatus == true)
                    {
                            Console.WriteLine(custList[i].firstName + " " + custList[i].lastName + " is of legal age");
                            Console.WriteLine(custList[i].firstName + " " + custList[i].lastName + " has a Premium membership.");
                    }

                    
                }





            }
    }
}

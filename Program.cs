using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8___String_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo of Lesson
            string name = "Aldworth";
            string name2;
            string yearString;
            int year = 1982;
            //Exercise variables
            string firstName, lastName, studentNumber, username, email, reverseName, backwards, word;

            //Access by index
            Console.WriteLine("Examples of Length and access by index:");
            Console.WriteLine(name.Length);
            Console.WriteLine(name[name.Length - 1]);       //prints last character
            Console.WriteLine("");
            Console.WriteLine("");

            //SUBSTRING EXAMPLES
            Console.WriteLine("Examples from Substring Tutorial:");
            Console.WriteLine("");
            Console.WriteLine(name.Substring(1, name.Length - 2));  //prints all characters except first and last
            Console.WriteLine(name[0] + name.Substring(5, 2));      //prints first, sixth and seventh letters
            yearString = year + "";                                 //converts integer to a string
            
            //Swaps first and last letter as per example and prints it
            name = name[name.Length - 1] + name.Substring(1, name.Length - 2) + name[0];
            Console.WriteLine(name);

            //Swaps first and last letter as per example with two examples of case fixing and prints it
            name = "Aldworth";
            name = char.ToUpper(name[name.Length - 1]) + name.Substring(1, name.Length - 2) + (name[0] + "").ToLower();
            Console.WriteLine(name);

            //Comparing Strings
            name = "Aldworth";
            name2 = "aldworth";
            if (name == name2)  // could replace with: (name.Equals(name2))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            //Compare ignoring case
            if (name.Equals(name2, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            Console.WriteLine("");
            Console.WriteLine("");

            //Solutions to Exercise 1
            Console.WriteLine("Solution to Exercise 1 - Username and Email Address");
            Console.WriteLine("");
            Console.WriteLine("Please enter your first name:");
            firstName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter your last name:");
            lastName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter your student number:");
            //Since there are no requirements specifying this be an integer we can read it in as a string
            studentNumber = Console.ReadLine().Trim();

            username = lastName.Substring(0, 3) + firstName.Substring(0, 3) + studentNumber.Substring(studentNumber.Length - 3, 3);
            username = username.ToLower();

            email = firstName[0] + lastName + "@parkside.ca";
            email = email.ToLower();

            Console.WriteLine("");
            Console.WriteLine($"Welcome {firstName}.  Your username is: {username}, and email is: {email}");

            Console.WriteLine("");
            Console.WriteLine("");

            //Solutions to Exercise 2
            Console.WriteLine("Solution to Exercise 2 - Reverse String");
            Console.WriteLine("");
            firstName = firstName.ToUpper();    //a
            lastName = lastName.ToLower();      
            reverseName = firstName + lastName; //b

            //Using loops
            backwards = "";
            for (int i = 0; i < reverseName.Length; i++)    //loops throguh each character starting at the beginning
                backwards = reverseName[i] + backwards;     //puts each character at the beginning of the word

            Console.WriteLine($"Here is {reverseName} reversed: {backwards}");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");

            //Solution to Exercise 3
            Console.WriteLine("Solution to Exercise 3 - Palindrome Checker");
            Console.WriteLine("");
            Console.WriteLine("Please enter a word:");
            word = Console.ReadLine();

            backwards = "";
            for (int i = 0; i < word.Length; i++)
                backwards = word[i] + backwards;

            if (word.Equals(backwards, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"{word} is a palindrome");
            else
                Console.WriteLine($"{word} is not a palindrome");

            Console.WriteLine("");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age= 42;
            Console.WriteLine(age);
            Console.ReadLine();
            ////////////////////////////////////////////       
            int a = 1;
            int b = 2;
           
            int sum = a + b;
            int mul = a * b;
            int min = a - b;

            Console.WriteLine(sum);
            Console.WriteLine(mul);
            Console.WriteLine(min);

            Console.WriteLine($"sum = {sum} mul = {mul} min = {min}");
            Console.WriteLine( "sum = {0}\nmul = {1}\nmin = {2}", sum,mul,min);
            Console.ReadLine();
            /////////////////////////////////////////
            string address;
            address = "Islamabad PK";
            Console.WriteLine(address);
            Console.ReadLine();

            string Firstname;
            string LastName;
            Firstname = "Anwar";
            LastName = "Ali";
            Console.WriteLine(Firstname);
            Console.WriteLine(LastName);
            string FullName;
            FullName = Firstname + " "+ LastName;
            Console.WriteLine(FullName);
            Console.ReadLine();
            /////////////////////////////////////////
            double dec;
            dec = 1.4;
            Console.WriteLine(dec);
            Console.ReadLine();
            //////////////////////////////////////////
            float ft;
            ft = 1.5f;
            Console.WriteLine(ft);
            Console.ReadLine();
            ///////////////////////////////////////////
            string n;
            Console.Write("Enter your name: ");
            n = Console.ReadLine();
            Console.WriteLine("Your Name is: " + n);
            Console.WriteLine("n = {0}", n);
            Console.ReadLine();
            /////////////////////////////////////////////
            int currentage;
            Console.Write("Enter Your Age: ");
            currentage = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Age is:" + currentage);
            Console.ReadLine();
            /////////////////////////////////////////////
            float ftval;
            Console.Write("Please enter val of ft: ");
            ftval = float.Parse(Console.ReadLine());
            Console.WriteLine("Your Float Value is: " + ftval);
            Console.ReadLine();











        }
    }
}

using MyCSharpApp.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyCSharpApp
{
    public enum ShippingMethod //different type - declare at namespace level
    {
        RegularMail = 1,
        RegisterMail = 2,
        Express = 3
    }

    public class Person
    {
        public string firstName;
        public string lastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*byte num = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'I';
            string firstName = "Impa";
            bool isWroking = false;*/

            var num = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'I';
            var firstName = "Impa";
            var isWroking = false;

            /*checked
            {
                num = 255;
                num = num + 1;
            }*/

            Console.WriteLine(num);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWroking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            /*const float Pi = 3.14f;
            Pi = 1; //cannot modify constants*/

            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int ii = 1; //if exceeding the limit of byte will result in data loss
            byte bb = (byte)ii; //cannot implicitly convert
            Console.WriteLine(bb);

            var number = "1234";
            //int i = (int)number; //non-compatible type - cannot convert string to int
            int iii = Convert.ToInt32(number);
            //int iii = int.Parse(number);
            //byte bbb = Convert.ToByte(number); //Overflow Exception
            Console.WriteLine(iii);
            //Console.WriteLine(bbb);
            
            try
            {
                byte bbb = Convert.ToByte(number);
                Console.WriteLine(bbb);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            try
            {
                string str = "true";
                bool bbbb = Convert.ToBoolean(str);
                Console.WriteLine(bbbb);
            }
            catch (Exception)
            {

                throw;
            }

            var x = 10;
            var y = 3;
            var z = 3;

            Console.WriteLine(x+y);
            Console.WriteLine((float)x/(float)y);
            Console.WriteLine((x + y) * z);
            Console.WriteLine(x != y);
            Console.WriteLine(x == y); //Console.WriteLine(!(x != y));
            Console.WriteLine(z > y && z < x);

            Sample sample = new Sample();
            sample.name = "Impa";
            sample.Introduce();

            Person person = new Person();
            person.firstName = "John";
            person.lastName = "Smith";
            person.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            //int[] numbers = new int[3];
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]); // when not initialized - set to default type value , here it is 0
            Console.WriteLine(numbers[2]); // default type value = 0

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); // default type value = false
            Console.WriteLine(flags[2]); // default type value = false

            var names = new string[3] { "Jack", "John", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);
            //string myName = "Impa";
            var myName = "Impa";
            //String lName = "Naik"; //using String class same as using string type
            var lName = "Naik";
            var fullName = myName + " " + lName;
            var myFullName = string.Format("My name is {0} {1}", myName, lName);

            //var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            //Using Verbatim string - @
            var text = @"Hi John
Look into the following paths
c:\\folder1\\folder2
c:\\folder3\\folder4";
            Console.WriteLine(text);

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //cast to obtain the integer - value

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId); //cast to obtain the method - key

            //Convert Enum to String
            Console.WriteLine(method.ToString());

            //Convert String to Enum - by using Parsing
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            //Value Type - memory allocated on stack
            var a1 = 10;
            var b1 = a1;
            b1++;
            Console.WriteLine(string.Format("a : {0}, b : {1}", a1, b1));

            //Reference Type - memory allocated on heap
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            var number1 = 1;
            Increment(number1);
            Console.WriteLine(number1);

            var person1 = new Person() { Age = 20 };
            MakeOld(person1);
            Console.WriteLine(person1.Age);

            int hour = 10;
            if (hour > 0 && hour <12)
            {
                Console.WriteLine("It's morning!!!");
            } else if (hour >=12 && hour < 18)
                Console.WriteLine("It's afternoon!!!");
              else
                Console.WriteLine("It's evening!!!");


            bool isGoldCustomer = true;
            /*float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;*/
            float price = isGoldCustomer ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect time to go to beach");
                    break;
                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("I do not know this season");
                    break;
            }

            //Exercises
            //var inp = Convert.ToInt32(Console.ReadLine()); //Read an input from user

            int input = 5;
            if (input >= 1 && input <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            int val1 = 2;
            int val2 = 6;
            if (val1 > val2)
                Console.WriteLine("Max value is {0}", val1);
            else
                Console.WriteLine("Max value is {0}", val2);

            float width = 100;
            float height = 250;
            var image = (width < height) ? "Portrait" : "Landscape";
            Console.WriteLine(image);

            var speedLimit = 200;
            var carSpeed = 80;
            //Given : for every 5kmph = 1 demerit
            var demerit = carSpeed / 5;
            var check = (demerit < 12) ? "Good" : "Liecense suspended";
            Console.WriteLine(check);

            for (var ix = 1; ix <= 10; ix++)
            {
                if (ix % 2 == 0)
                    Console.Write(ix);
            }
            Console.WriteLine();
            for (var ix = 10; ix >= 0; ix--)
            {
                if (ix % 2 == 0)
                    Console.Write(ix);
            }
            Console.WriteLine();

            var name = "John Smith";
            for (var ix = 0; ix < name.Length; ix++)
                Console.Write(name[ix]);
            Console.WriteLine();

            foreach (var newChar in name)
                Console.Write(newChar);
            Console.WriteLine();


            var newSet = new int[] { 1, 2, 3, 4 };
            foreach (var n in newSet)
                Console.Write(n);
            Console.WriteLine();

            var xx = 0;
            while (xx <= 10)
            {
                if (xx % 2 == 0)
                    Console.Write(xx);
                xx++;
            }
            Console.WriteLine();

            /*while(true)
            {
                Console.Write("Type your name : ");
                var userInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userInput))
                    break;

                Console.WriteLine("@Echo : " + userInput);
            }*/

            while (true)
            {
                Console.Write("Type your name : ");
                var userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("@Echo : " + userInput);
                    continue;
                }
                break;
            }

            var random = new Random();
            for(var w=0; w<10; w++)
                Console.Write(random.Next(1, 10));
            Console.WriteLine("\n");
            for (var w = 0; w < 10; w++)
                Console.Write((char)random.Next(97, 122)); //ASCII interpretation
            Console.WriteLine();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var w = 0; w < passwordLength; w++)
                buffer[w] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);

            //Exercises
            var count1 = 0;
            for(z=1; z<=100; z++)
            {
                if (z % 3 == 0)
                    count1++;
            }
            Console.Write(count1);

            /*var sum = 0;
            while(true)
            {
                var value = Console.ReadLine();
                sum = sum + (int)value;
                if (value == "ok")
                    break;
            }*/
            Console.WriteLine();

            /*var number11 = Console.Read();
            var factorial = 0;
            var w = number11;
            while(w > 0)
            {
                factorial = w * (w-1);
                //continue;
                w--;
            }
            Console.WriteLine("{0}! = {1}", number11, factorial);*/

            /*Console.Write("Enter the number : ");
            var userInput = Console.Read();
            while (true)
            {
                var max = 0;
                if (userInput > max)
                    max = userInput;

                if (userInput)
                    break;

                Console.WriteLine("@Echo : " + userInput);
            }*/

            var numbers1 = new[] { 3, 5, 10, 2, 8, 9 };

            //Length
            Console.WriteLine("Length: " + numbers1.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers1, 8);
            Console.WriteLine("Index of 5: " +index);

            //Clear()
            Array.Clear(numbers1, 0, 2);
            Console.WriteLine("Array after Clear()");
            foreach(var n in numbers1)
                Console.WriteLine(n);

            //Copy()
            var another = new int[3];
            Array.Copy(numbers1, another, 3);
            Console.WriteLine("Array after Copy()");
            foreach(var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers1);
            Console.WriteLine("Array after Sort()");
            foreach (var n in numbers1)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers1);
            Console.WriteLine("Array after Reverse()");
            foreach (var n in numbers1)
                Console.WriteLine(n);

            var list = new List<int>() { 1, 2, 3, 4 };
            list.Add(1); //can add as many as required - dynamic length
            list.AddRange(new int[3] { 5, 6, 7 });
            foreach(var l in list)
                Console.Write(l);
            Console.WriteLine();

            Console.WriteLine("Index of 1 : " + list.IndexOf(1)); // if doesn't exists, then return -1
            Console.WriteLine("Last Index of 1 : " + list.LastIndexOf(1)); // search from the end of the list
            Console.WriteLine("Count: "+ list.Count);

            /*list.Remove(1);
            foreach (var l in list)
                Console.Write(l);
            Console.WriteLine();*/

            //To remove all 1s
            /*foreach (var l in list)
            {
                if(l ==1)
                    list.Remove(1);
            }
            foreach (var l in list)
                Console.Write(l);
            Console.WriteLine();*/
            //On execution, application crashes throwing exception : System.InvalidOperationException: 'Collection was modified; 
            //In C#, we are not allowed to modify the collection inside a foreach loop
            //Solution: Use for loop

            for (var l=0; l < list.Count; l++)
            {
                if (list[l] == 1)
                    list.Remove(list[l]);
            }
            foreach (var l in list)
                Console.Write(l);
            Console.WriteLine();

            list.Clear(); //Removes all items from the list
            Console.WriteLine("Count: "+ list.Count);

            var dateTime = new DateTime(2021, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: "+ now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            //Formatting
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            var timeSpan = new TimeSpan(1, 2, 3); //(hour, minute, seconds) - if no value pass 0s
            var timeSpan1 = new TimeSpan(1, 0, 0);
            //OR
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("The time span is "+ duration);

            //Properties
            Console.WriteLine("Minutes : " + timeSpan1.Minutes);
            Console.WriteLine("Total Minutes : " + timeSpan1.TotalMinutes);
            Console.WriteLine("Add Example : " + timeSpan1.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example : " + timeSpan1.Subtract(TimeSpan.FromMinutes(2)));
            Console.WriteLine("ToString : " + timeSpan1.ToString());
            Console.WriteLine("Parse : " + TimeSpan.Parse("01:02:03"));

            var fullName1 = "Impa S ";
            Console.WriteLine("Trim: '{0}'", fullName1.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName1.Trim().ToUpper());

            var index1 = fullName1.IndexOf(' ');
            var firstName1 = fullName1.Substring(0, index1);
            var lastName1 = fullName1.Substring(index1 + 1);
            Console.WriteLine("First Name : " + firstName1);
            Console.WriteLine("Last Name : " + lastName1);

            var names1 = fullName1.Split(' ');
            Console.WriteLine("First Name : " + names1[0]);
            Console.WriteLine("Last Name : "+ names1[1]);

            var fullNameEdited = fullName1.Replace("S", "Naik");
            Console.WriteLine("My name after Replace() : " + fullNameEdited);

            if(String.IsNullOrEmpty(null)) //or pass "" - gives Invalid
                Console.WriteLine("Invalid");

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str1 = "25";
            var age1= Convert.ToByte(str1);
            Console.WriteLine(age1);

            float price1 = 29.95f;
            Console.WriteLine(price1.ToString("C0"));

            //Summarizing Text
            var sentence = "This is going to be a really really really really really long text";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);

            //String Manipulation
            var builder = new StringBuilder("Hello World")
                .Append('-', 10) //Append returns StringBuilder object
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '=')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First Char : " + builder[0]);

            //Procedural Programming
            Console.Write("What is your name ? ");
            var username = Console.ReadLine();
            var reversed = ReverseName(username);
            Console.WriteLine("Reveresed name : " + reversed);

            /*var numbers2 = new List<int>();
            while(true)
            {
                Console.Write("Enter a number (or Quit to exit) : ");
                var input2 = Console.ReadLine();
                if (input2.ToLower() == "quit")
                    break;
                numbers2.Add(Convert.ToInt32(input2));
            }
            var uniques = GetUniqueNUmbers(numbers2);
            Console.WriteLine("Unique Numbers : ");
            foreach (var number2 in uniques)
                Console.WriteLine(number2);*/

            //Files - static methods
            /*var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile.jpg", true);
            File.Delete(path);
            if(File.Exists(path))
            {
                //...
            }
            var content = File.ReadAllText(path);*/
            //FileInfo - instance methods
            /*var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                //...
            }*/

            //Directory - static methods
            //Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"C:\Users\impa1\OneDrive\Documents\IBM", "*.png*", SearchOption.AllDirectories); //Path , SearchPattern , SearchOptions
            foreach(var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Users\impa1\OneDrive\Documents\IBM", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            //Directory.Exists("...");

            //DirectoryInfo - instance methods
            /*var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();*/

            var path1 = @"c:\temp\folder1\folder2\file1.png";
            /*var dotINdex = path1.IndexOf('.');
            var extension = path1.Substring(dotINdex);*/

            Console.WriteLine("Extension : " + Path.GetExtension(path1));
            Console.WriteLine("File Name : " + Path.GetFileName(path1));
            Console.WriteLine("File Name Without Extension : " + Path.GetFileNameWithoutExtension(path1));
            Console.WriteLine("Directory Name : " + Path.GetDirectoryName(path1));


            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id); //default = 0
            Console.WriteLine(customer.Name); //default = null


        }

        public static string ReverseName(string name)
        {
            //Business Logic
            var array = new char[name.Length];
            for (var w = name.Length; w > 0; w--)
                array[name.Length - 1] = name[w - 1];
            return new string(array);
        }
          
        public static List<int> GetUniqueNUmbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number2 in numbers)
            {
                if (!uniques.Contains(number2))
                    uniques.Add(number2);
            }
            return uniques;
        }

        static void Increment(int number)
        {
            number += 10;
        }

        static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}

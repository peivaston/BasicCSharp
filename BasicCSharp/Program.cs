using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string myName = "Peivaston";
            string message = "My name is " + myName;

            string capsMessage = message.ToUpper();
            string lowMessage = message.ToLower();





            Console.WriteLine(capsMessage);
            Console.WriteLine(lowMessage);
            Console.Read();

*/




            /*Console.WriteLine("Enter a string and press enter :");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.WriteLine("Enter a string and press enter :");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:",asciiValue);
            Console.ReadKey();


*/
            /* double myDouble = 13.37;
             int myInt;

             //cast double into int;
             //explicit conversion

             myInt = (int)myDouble;

             // implicit conversion

             int num = 1235435456;
             long bigNum = num;

             float myFloat = 13.37F;
             double myNewDouble = myFloat;

             // type conversion
             string myString = myDouble.ToString();
             string myFloatString = myFloat.ToString();
             bool sunIsShining = true;

             string myBoolString = sunIsShining.ToString();

             Console.WriteLine(myInt);
             Console.Read();
 */
            /*string myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;

            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();


*/
            /* int age = 26;
             string name = "Peivaston";
             string job = "Developer";

             // 1. string concatenation
             Console.WriteLine("String Concatenation");
             Console.WriteLine("Hello, my name is " + name + " And I am " + age + " years old");

             // 2. string formatting
             // string formatting uses index

             Console.WriteLine("String formatting");
             Console.WriteLine("Hello my name is {0}, I am {1} yearls old and I'm a {2} ", name, age, job);

             // 3. String interpolation.
             // String interpolation uses $ at the start which will allow us to write our variables like this {variableName}
             Console.WriteLine("String interpolation");
             Console.WriteLine($"Hello my name is {name}, I'm {age} years old and I'm a {job}");

             // 4. verbatim strings.
             // Verbatim strings start with @ and tells the compiler to take the string 
             // literally and ignore any spaces and escape characters like \n

             Console.WriteLine("Verbatim Strings");
             Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                 Proin cursus mattis diam, sed tincidunt tellus rutrum a.
                 Quisque lacinia, felis a porttitor cursus, mi diam venenatis est, eu volutpat felis nulla nec metus.  ");

 */

            // Challenge String and its methods

            /*  string myName;
              Console.Write("Please enter your name and press enter: ");
              myName = Console.ReadLine();
              string myNameUppercase = String.Format("Upper case : {0}", myName.ToUpper());
              string myNameLower = String.Format("Lower case : {0}", myName.ToLower());
              string myNameTrimmed = string.Format("Trimmed value : {0}", myName.Trim());
              string myNameSubString = string.Format("SubString value {0}", myName.Substring(0, 5));

              Console.WriteLine(myNameUppercase);
              Console.WriteLine(myNameLower);
              Console.WriteLine(myNameTrimmed);
              Console.WriteLine(myNameSubString);

              Console.ReadKey();

  */
            Console.Write("Enter a string here: ");
            Console.Write("Enter the character to search".ToCharArray());








        }
    }
}

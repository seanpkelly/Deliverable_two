using System;
using System.Text;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int checksum = 0;
            string input;
            string message = "";
            Console.Write("What is your message?");
            input = Console.ReadLine();

            // string converted to Upper case 
            string inputUpper = input.ToUpper();

            //converting inputUpper to a CharArray then putting it into indiC
            char[] indiC = inputUpper.ToCharArray();
            Console.Write("Your encoded message is:  ");
            foreach (char element in indiC)
            {

                //Console.WriteLine($"Element #: {element}");
                //Console.WriteLine(char.ToUpper(element) - (64));
                message = message + (char.ToUpper(element) - (64)).ToString() + "-";

            }

            Console.WriteLine(message);



            //byte[] bytes = Encoding.Unicode.GetBytes("C");
            //Console.WriteLine(bytes[0].ToString());
            int myInt = 0;

            foreach (char element in indiC)
            {
                string letter = element.ToString();
                byte[] bytes = Encoding.Unicode.GetBytes(letter);
                Console.WriteLine(bytes[0].ToString());


                myInt = myInt + bytes[0];
            }
            Console.Write("Message checksum is:  ");


            checksum = myInt;

            Console.WriteLine(checksum.ToString());

            Console.ReadLine();
        }
    }
}

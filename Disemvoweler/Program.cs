using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Original : Nickleback is my favorite band. Their songwriting can't be beat!") ;
          Console.WriteLine("Disemvoweled: " + disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!"))  ;
          Console.WriteLine("Original : How many bears could bear grylls grill if bear grylls could grill bears");
          Console.WriteLine("Disemvoweled : " + disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears"));
          Console.WriteLine("Original : I'm a code ninja, baby. I make the functions and I make the calls.");
          Console.WriteLine("Disemvoweled : " + disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls."));


          Console.ReadKey();
        }
        //Create a function called disemvoweler that takes a string parameter called "inString"
        static string disemvoweler  (string inString)
        {   
            var returnString = "";
            var deVowel = "";
               for (var i = 0; i < inString.Length; i++)
               {
                   var a = inString[i];
                   if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                   {
                       
                       deVowel += a;
                       
                   }
                   else
                   {
                returnString +=a ;

                   }
               }

               return returnString;


               

           }
        
    



    }
}

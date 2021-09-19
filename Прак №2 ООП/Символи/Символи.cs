using System;

namespace Символи
{
    class Program
    {
        static void Main(string[] args)
        {
            char char_literal = 'A'; // Character literal
            char hexadecimal = '\x0041';//Hexadecimal
            char integer = (char)65;//Csat from integral type
            char unicode = '\u0041';// Unicode
            Console.WriteLine(char_literal + "" + hexadecimal + "" + integer + "" + unicode);
            Console.ReadKey();
        }   
    }
}

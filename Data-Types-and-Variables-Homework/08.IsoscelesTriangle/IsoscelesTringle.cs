using System;
using System.Text;

    class IsoscelesTringle
    {
        static void Main()
        {
            char utfCopyright = '\u00A9';           //"00A9: is the UTF-8 hexadecimal value for the copyright sign.

            Console.OutputEncoding = Encoding.UTF8;  // Console encoding chnaged to UTf-8. Namespace System.Text is required.
                                                     // Try 'Lucida Console' font to visualize


            //Draw the triangle.

            Console.WriteLine("       " + utfCopyright + "   \n\n");
            Console.WriteLine("      " + utfCopyright + " " + utfCopyright + "  \n\n");
            Console.WriteLine("     " + utfCopyright + "   " + utfCopyright + " \n\n");
            Console.WriteLine("    "+ utfCopyright + " " + utfCopyright + " " + utfCopyright + " " + utfCopyright);
        }
    }

using System;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1
            string s = "Бык тупогуб, тупогубенькй бычок, у быка губа бела была тупа ";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Null");
            }
            */


            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))"+
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            while (true)
            {
                Console.WriteLine("Enter Email adress: ");
                string email = Console.ReadLine();

                if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Email = True");
                    break;
                }
                else
                {
                    Console.WriteLine("Email = False");
                }
            }
        }
    }
}

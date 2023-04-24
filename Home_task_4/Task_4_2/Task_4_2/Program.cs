using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {//ви не навели всю систему тестів з Вікіпедії
            string text = "simple@example.com very.common@example.com A@b@c@example.com this is\"not\\allowed@example.com";

            EmailFinder.FindMailsAndLexems(text);
        }
    }

    public static class EmailFinder
    {
        public static void FindMailsAndLexems(string text)
        {
            IEnumerable<string> splitedText = text.Split(' ').Where(part => part.Contains("@"));

            List<string> mails = new List<string>();
            List<string> lexemes = new List<string>();

            foreach (string partOfText in splitedText)
            {
                if (IsMail(partOfText))
                {
                    mails.Add(partOfText);
                }
                else
                {
                    lexemes.Add(partOfText);
                }
            }
            Console.WriteLine("Mails:");
            foreach (string mail in mails)
            {
                Console.WriteLine(mail);
            }
            Console.WriteLine("Lexems:");
            foreach (string lexem in lexemes)
            {
                Console.WriteLine(lexem);
            }
        }

        private static bool IsMail(string row)
        {
            try
            {
                MailAddress address = new MailAddress(row);
                return address.Address == row;
            }
            catch
            {
                return false;
            }
        }
    }
}

using System;

using System.Linq;

using System.Text.RegularExpressions;


namespace FirstTest

{

    internal class EnterPassword

    {
        // Метод для проверки длины пароля
        public int Enter_contain10(string password)
        {
            return password.Length;
        }
        // Метод для подсчета специальных символов в пароле
        public int Enter_containSpecS(string password)
        {
            var regex = new Regex(@"[\W_]");
            return password.Count(c => regex.IsMatch(c.ToString()));
        }
        public int Enter_containNum(string password)
        {
            var regex = new Regex(@"[0-9]");
            return password.Count(c => regex.IsMatch(c.ToString()));
        }
        public int Enter_containZog(string password)
        {
            var regex = new Regex(@"[A-Z]");
            return password.Count(c => regex.IsMatch(c.ToString()));
        }
        public int Enter_containNZog(string password)
        {
            var regex = new Regex(@"[a-z]");
            return password.Count(c => regex.IsMatch(c.ToString()));
        }
    }

}
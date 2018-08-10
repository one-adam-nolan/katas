using System;

namespace GreetingKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Greeter 
    {
        private bool IsNotNull(string s) => s != null;
        private bool IsAllCaps(string s) => s.ToUpper() == s;

        public string Greet(string name)
        {
            if (IsNotNull(name) && IsAllCaps(name))
                return $"HELLO {name}!";
            return $"Hello, {(IsNotNull(name) ? name : "My Friend")}";
        }
    }
}
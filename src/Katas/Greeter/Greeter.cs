using System.Collections.Generic;

namespace Katas.Greeter
{
    public class Greeter
    {
        private readonly string DefaultName = "My Friend";
        private bool IsNull(object s) => s == null;
        private bool IsNotNull(object s) => s != null;
        private bool IsAllCaps(string s) => s.ToUpper() == s;
        private bool IsMultipleNames(string[] names) => names.Length > 1;
        private string AllCapsResponse(string name) => $"HELLO {name}!";
        private string StandardResponse(string name) => $"Hello, {name}";
        private List<string> _nonCapNames = new List<string>();
        private List<string> _capNames = new List<string>();


        public string Greet(params string[] names)
        {
            if (IsNull(names))
                return StandardResponse(DefaultName);

            return IsMultipleNames(names) ?
                        HandleMultipleNames(names) :
                        HandleSingleName(names[0]);
        }

        private string HandleMultipleNames(string[] names)
        {
            var concatedNames = "Hello, ";



            for (int i = 0; i < names.Length; ++i)
            {
                if (i == 0 || i < (names.Length - 1))
                    concatedNames += names[i];
                else
                    concatedNames += $" and {names[i]}";
            }

            return concatedNames;
        }

        private string HandleSingleName(string name)
        {
            return IsAllCaps(name) ?
                AllCapsResponse(name) :
                StandardResponse(name);
        }

    }
}
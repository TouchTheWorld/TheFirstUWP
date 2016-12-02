using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirst
{
    class Message
    {
        private static List<string> names = new List<string>();
        private static List<string> passwords = new List<string>();
        public Message() { }
        public Message(string name, string password)
        {
            names.Add(name);
            passwords.Add(password);
        }

        public bool search(string name)
        {
            return names.Contains(name);
        }
        public bool martch(string name,string password)
        {
            int index = 0;
            foreach (string str in names)
            {
                if (str.Equals(name))
                   break;
                index++;
            }
            if (passwords[index] == password)
                return true;
            else
                return false;
        }
        public void regin(string name, string password)
        {
            names.Add(name);
            passwords.Add(password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_06task
{


    internal class Info
    {
        public int Age;
        public string Gender;
        public string Name;
        public string Email;
        public string ID;
        public string Phone;

        public void InfoView()
        {
            Console.WriteLine($"Age is: {Age}, Gender is: {Gender}, Name is: {Name}, Email is: {Email}, ID is: {ID}, Phone is: {Phone}");
        }
    }
}


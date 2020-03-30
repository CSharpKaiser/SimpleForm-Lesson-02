using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForm.Model
{
    class Person
    {
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Title = "";
            Forename = "";
            Surname = "";
        }

        public override string ToString()
        {
            return "Title = " + Title + " Forename = " + Forename + " Surname = " + Surname;
        }
    }
}

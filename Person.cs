using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        string DPI;
        string Name;
        string lastName;
        DateTime dateBirthday;

        public string DPI1 { get => DPI; set => DPI = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateBirthday { get => dateBirthday; set => dateBirthday = value; }
    }
}

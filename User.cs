using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    public class User
    {
        private string surname;
        private string name;
        private string futhersname;
        private int age;

        public User(string surname, string name, string futhersname, int age)
        {
            this.surname = surname;
            this.name = name;
            this.futhersname = futhersname;
            this.age = age;
        }

        public void Snfa()
        {
            Console.WriteLine(surname);
            Console.WriteLine(name);
            Console.WriteLine(futhersname);



        }
    }

}

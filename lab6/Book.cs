using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab6
{
    public class Book
    {
        public string Name { get; set; }
        public double Number { get; set; }

        public Book(string name, double number)
        {
            this.Name = name;
            this.Number = number;
        }
        public override string ToString()
        {
            return "Название книги: " + Name + "   Стоимость: " + Number + " рублей";
        }

    
    }
}

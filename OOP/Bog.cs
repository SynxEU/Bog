using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Bog
    {
        public string Title { get; set; }
        public string Forfatter { get; set; }
        public Bog(string title, string forfatter)
        {
            Title = title;
            Forfatter = forfatter;
        }
    }
}

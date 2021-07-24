using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.MyStuff
{
    class Tool
    {
        public string Type { get; set; }
        public string Size { get; set; }

        bool _inToolbox;
        bool _isDirty;

        public Tool (string type, string size)
        {
            Type = type;
            Size = size;
            _inToolbox = true;
            _isDirty = false;
        }

        public void Retrieve()
        {
            _inToolbox = false;
        }

        public void Use()
        {
            if(_inToolbox)
            {
                Console.WriteLine($"               Trying to use the {Type}.");
                Console.WriteLine($"               You must retrieve the {Type} before using it.");
            }

            else
            {
            Console.WriteLine($"               Now using the {Type}.");
            _isDirty = true;
            }
        }

        public void Return()
        {
            Console.WriteLine($"               Returning the {Type} to the toolbox");
            if (_isDirty == true)
            {
                Console.WriteLine($"               You must clean the {Type} before returning it to the toolbox");
            }
            else
            {
                _inToolbox = true;
            }
        }

        public void Clean()
        {
            Console.WriteLine($"               Cleaning the {Type}.");
            _isDirty = false;
        }
        public void Status()
        {
            Console.WriteLine($"               {Type} status:");
            if (_inToolbox)
            {
                Console.WriteLine($"               The {Type} is in the toolbox");
            } else
            {
                Console.WriteLine($"               The {Type} is in use");
            }
            if (_isDirty)
            {
                Console.WriteLine($"               The {Type} needs to be cleaned");
            }
            else
            {
                Console.WriteLine($"               The {Type} is clean");
            }

        }
    }
}

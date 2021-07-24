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
                Console.WriteLine($"You must retrieve the {Type} before using it.");
            }

            else
            {
            _isDirty = true;
            }
        }

        public void Return()
        {
            if (_isDirty == true)
            {
                Console.WriteLine($"You must clean the {Type} before returning it to the toolbox");
            }
            else
            {
                _inToolbox = true;
            }
        }

        public void Clean()
        {
            _isDirty = false;
        }
        public void Status()
        {
            if (_inToolbox)
            {
                Console.WriteLine($"The {Type} is in the toolbox");
            } else
            {
                Console.WriteLine($"The {Type} is in use");
            }
            if (_isDirty)
            {
                Console.WriteLine($"The {Type} needs to be cleaned");
            }
            else
            {
                Console.WriteLine($"The {Type} is clean");
            }

        }
    }
}

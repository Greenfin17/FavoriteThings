using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.MyStuff
{
    class Violin
    {
        public string Maker { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Tone { get; set; }

        bool _stringsHaveRosin;
        bool _inTune;
        bool _violinInCase;

        public Violin(string maker, string year, string color, string tone)
        {
            Maker = maker;
            Year = year;
            Color = color;
            Tone = tone;

            _stringsHaveRosin = false;
            _inTune = false;
            _violinInCase = true;
        }

        public void Play()
        {
            if(_violinInCase)
            {
                Console.WriteLine("You must take the violin out of the case to play it.");
            }
            else if (_inTune)
            {
                Console.WriteLine("Fa la la la la");
            } else
            {
                Console.WriteLine("You need to tune the violin");
            }
        }

        public void Retrieve()
        {
            _inTune = false;
            _stringsHaveRosin = false;
            _violinInCase = false;
        }

        public void Return()
        {
            if(_stringsHaveRosin)
            {
                Console.WriteLine("You must clean the rosin off of the strings before returning the violin to the case");
            }
            else
            {
                _violinInCase = true;
            }

        }

        public void Tune()
        {
            _inTune = true;
            Console.WriteLine("The violin is now in tune");
        }

        public void Clean()
        {
            _stringsHaveRosin = false;
            Console.WriteLine("Thanks, the violin strings are now clean.");
        }
    }
}

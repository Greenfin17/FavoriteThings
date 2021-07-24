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

            Console.WriteLine("               Trying to play the violin.");
            if(_violinInCase)
            {
                Console.WriteLine("               You must take the violin out of the case to play it.");
            }
            else if (_inTune)
            {
                Console.WriteLine("               Playing the violin");
                Console.WriteLine("               Fa la la la la");
                _stringsHaveRosin = true;
            } else
            {
                Console.WriteLine("               You need to tune the violin before playing it.");
            }
        }

        public void Retrieve()
        {
            Console.WriteLine("               Retrieving violin from case");
            _inTune = false;
            _stringsHaveRosin = false;
            _violinInCase = false;
        }

        public void Return()
        {
            Console.WriteLine("               Trying to return the violin to it's case.");
            if (_stringsHaveRosin)
            {
                Console.WriteLine("               You must clean the rosin off of the strings before returning the violin to the case.");
            }
            else
            {
                Console.WriteLine("               The violin is now in it's case.");
                _violinInCase = true;
            }

        }

        public void Tune()
        {
            _inTune = true;
            Console.WriteLine("               Tuning the violin.");
            Console.WriteLine("               The violin is now in tune");
        }

        public void Clean()
        {
            _stringsHaveRosin = false;
            Console.WriteLine("               Cleaning the violin.");
            Console.WriteLine("               Thanks, the violin strings are now clean.");
        }

        public void Status()
        {
            Console.WriteLine($"               {Maker}, {Year}, Finish: {Color}, Tone: {Tone}");
        }
    }
}

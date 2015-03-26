using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.MyFirstDataTypes
{
    public struct Color
    {

        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }

        public Color(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
        }

        public static Color Red
        {
            get { return new Color(255, 0, 0); }
        }
        public static Color Green
        {
            get { return new Color(0, 255, 0); }
        }
        public static Color Blue
        {
            get { return new Color(0, 0, 255); }
        }
        public static Color Black
        {
            get { return new Color(0, 0, 0); }
        }
        public static Color White
        {
            get { return new Color(255, 255, 255); }
        }
    }
}

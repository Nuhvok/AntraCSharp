using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Color
    {
        private int red;
        private int blue;
        private int green;
        private int alpha;

        public Color(int red, int blue, int green, int alpha = 255)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.alpha = alpha;
        }

        public int Red
        {
            get => red;
            set => red = value;
        }

        public int Blue
        {
            get => blue;
            set => blue = value;
        }

        public int Green
        {
            get => green;
            set => green = value;
        }

        public int Alpha
        {
            get => alpha;
            set => alpha = value;
        }

        public int calculateGreyscale()
        {
            return (Red + Blue + Green) / 3;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Ball
    {
        private int size;
        private Color color;
        private int thrown;

        public Ball(int size, int red, int blue, int green, int alpha = 255)
        {
            this.size = size;
            this.color = new Color(red, blue, green, alpha);
            this.thrown = 0;
        }

        public int Size
        {
            get => size;
            set => size = value;
        }

        public Color Color
        {
            get => color;
            set => color = value;
        }

        public int Thrown
        {
            get => thrown;
        }

        public void popBall()
        {
            Size = 0;
        }

        public void throwBall()
        {
            if(Size > 0)
            {
                thrown++;
            }
        }
    }
}

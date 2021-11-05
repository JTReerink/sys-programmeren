using System;
using System.Collections.Generic;
using System.Text;

namespace Les3
{
    class Rectangle
    {
        private int x;
        private int y;
        private int width;
        private int height;
        public Rectangle(int x,int y,int width,int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }
        public Rectangle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            width = size;
            height = size;
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int size)
        {
            width = size;
            height = size;
        }

        public void MoveTo(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public bool isSquare()
        {
            if(width == height)
            {
                return true;
            }
            return false;
        }

        public void Set(int x, int y,int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}

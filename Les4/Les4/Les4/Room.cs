using System;
using System.Collections.Generic;
using System.Text;

namespace Les4
{
    class Room
    {
        int width;
        int height;

        int[][] tile = new int[10][];
        public void Room(int width,int height)
        {
            this.width = width;
            this.height = height;

        }

    }

}

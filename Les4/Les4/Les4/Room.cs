using System;
using System.Collections.Generic;
using System.Text;

namespace Les4
{
    class Room
    {
        private int width;
        private int height;

        private Tile[][] tile = new Tile[10][];



        public Room(int width,int height)
        {
            this.width = width;
            this.height = height;



            for (int i = 0; i < tile.Length; i++)
            {
                tile[i] = new Tile[width];

                for (int y = 0; y < tile[i].Length; y++)
                {
                    tile[i][y] = new Tile();
                }
            }
        }

    }

}

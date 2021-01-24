using System;
using System.Collections.Generic;
using System.Text;

namespace Matrrix_switch
{
    class Matrix
    {
        int[,] relays;
        public Matrix(int row, int col)
        {
            relays = new int[row, col];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    relays[j, i] = 0;
                }
            }
        }
        

        public void Switch(int row, int col)
        {
            //for (int i = 0; i < row; i++)
            //{
            //    relays[i, col] = 1;
            //}
            //for (int i = 0; i < col; i++)
            //{
            //    relays[col, i] = 1;
            //}
        }
        public void Reset()
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {

            //        relays[i, j] = 0;
            //    }
            //}
        }

        public void Switch2(int row, int n)
        {
            //int x = n - 1;
            //for (int i = 0; i < row; i++)
            //{
            //    relays[i, x] = 1;
            //}
            
        }
        public void Display()
        {
            for (int i = 0; i < relays.GetLength(0); i++)
            {
                for (int j = 0; j < relays.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", relays[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
        
    }
}

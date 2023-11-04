using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson23_09
{
    internal class Matrix
    {
        private static int seed;
        protected int i;
        protected int j;
        protected int[,] Arr;
        //protected Random rand ;
        static Matrix()
        {
            seed = 0;
        }
        public Matrix(int i, int j)
        {
            
            this.i = i;
            this.j = j;
            this.Arr = new int[i, j];
            //rand = new Random();
            //Thread.Sleep(1);
            Randomize();
        }

        public void Randomize(int min = 0, int max = 10)
        {
            Random rand = new Random(++seed);
            for (int index_i = 0; index_i < i; index_i++)
                for (int index_j = 0; index_j < j; index_j++)
                    Arr[index_i, index_j] = rand.Next(min, max);
        }

        public void Print()
        {
            for (int index_i = 0; index_i < i; index_i++)
            {
                for (int index_j = 0; index_j < j; index_j++)
                    Console.Write(Arr[index_i, index_j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A.i != B.i || A.j != B.j) throw new Exception("Sizes of matrixes should be equal!\n");
            Matrix Temp = new Matrix(A.i, A.j);


            for (int index_i = 0; index_i < A.i; index_i++)
                for (int index_j = 0; index_j < A.j; index_j++)
                    Temp.Arr[index_i, index_j] = A.Arr[index_i, index_j] + B.Arr[index_i, index_j];
            return Temp;
        }

        public static Matrix operator *(Matrix A, int number)
        {
            Matrix Temp = new Matrix(A.i, A.j);

            for (int index_i = 0; index_i < A.i; index_i++)
                for (int index_j = 0; index_j < A.j; index_j++)
                    Temp.Arr[index_i, index_j] = A.Arr[index_i, index_j] * number;
            return Temp;
        }

        public static Matrix operator *(int number, Matrix A)
        {
            Matrix Temp = new Matrix(A.i, A.j);

            for (int index_i = 0; index_i < A.i; index_i++)
                for (int index_j = 0; index_j < A.j; index_j++)
                    Temp.Arr[index_i, index_j] = A.Arr[index_i, index_j] * number;
            return Temp;
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {

            if (A.j != B.i) throw new Exception("Rows should be equal to rows.\n");

            Matrix MTemp = new Matrix(A.i, B.j);

            int temp = 0;
            for (int index_i = 0; index_i < A.i; index_i++)
            {
                for (int index_j = 0; index_j < B.j; index_j++)
                {

                    temp = 0;
                    for (int k = 0; k < A.j; k++)
                        temp += A.Arr[index_i, k] * B.Arr[k, index_j];
                    MTemp.Arr[index_i, index_j] = temp;
                }
            }
            return MTemp;
        }
    }
}

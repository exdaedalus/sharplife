using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using SharpLife.Lib;
using SharpLife.Lib.Conway;

namespace SharpLife.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(20, 10);
            b.Init(1, 1, new int[,] { { 1, 0 }, { 0, 1 } });
            b.Print();
        }
    }
}

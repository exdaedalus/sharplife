using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpLife.Lib
{
    public abstract class Game
    {
        protected Board _board = null;

        protected Game(Board b)
        {
            _board = b;
        }

        public virtual void Update()
        {
        }
    }
}

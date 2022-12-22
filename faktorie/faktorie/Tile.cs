using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorie
{
    public class Tile
    {
        public int Pos;
        public virtual void setPos()
        {
            Pos = 0;    
        }
        public Tile(int pos)
        {
            Pos = pos;

        }


    }




}

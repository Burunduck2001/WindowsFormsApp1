using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model
{
    public class RigidBodyRec //Rectangle
    {
        public decimal LocationX { get; set; }
        public decimal LocationY { get; set; }
        decimal Height { get; set; }
        decimal Width { get; set; }

        public RigidBodyRec(decimal objX, decimal objY, decimal objHeight, decimal objWidth)
        {
            LocationX = objX;
            LocationY = objY;
            Height = objHeight;
            Width = objWidth;
        }


    }
}

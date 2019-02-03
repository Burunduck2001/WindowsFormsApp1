using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model
{
    public class Door
    {
        public AbstractRoom From { get; set; }
        public AbstractRoom To { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public RigidBodyRec Size { get; set; }

        public Door(AbstractRoom from, AbstractRoom to)
        {

            From = from;
            To = to;
        }


    }
}

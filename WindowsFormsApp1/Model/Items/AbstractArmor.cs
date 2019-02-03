using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Items
{
    public abstract class AbstractArmor
    {

        int Durrability { get; set; }//Prochnost
        int minLvl { get; set; }
        int Defends { get; set; } //How much damage u can

    }
}

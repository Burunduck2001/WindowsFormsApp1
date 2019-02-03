using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Items
{
    public abstract class AbstractWeapon
    {
        int Damage { get; set; }
        bool MagDamage { get; set; } //Checked if damage is magic
        int minLvl { get; set; } //MinLvl when u can use this weapon
        int Durrability { get; set; }//Prochnost
        int Cooldown { get; set; } //The time for hit monster one more time
    }
}

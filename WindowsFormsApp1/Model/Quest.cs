using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model
{
    public class Quest
    {
        string Discription { get; set; }
        int XP { get; set; }
        int Gold { get; set; }
        int minLvlforEnter { get; set; }
        List <AbstractItem> Loot { get; set; }

    }
}

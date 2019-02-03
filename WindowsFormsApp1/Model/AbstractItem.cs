using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model
{
    public abstract class AbstractItem
    {
        int ID { get; set; }
        int Cost { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        enum Rarity
        {
            Common=1,
            Uncommon,
            Rare,
            Unique,
            Legendary,

        }
        

    }
}

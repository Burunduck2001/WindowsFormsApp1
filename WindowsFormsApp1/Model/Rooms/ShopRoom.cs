using CastleBetaForm.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleBetaForm.Model.Rooms
{
    class ShopRoom : AbstractRoom
    {
        public ShopRoom(AbstractRoom n, AbstractRoom e, AbstractRoom s, AbstractRoom w) : base(n, e, s, w)
        {
            Background = Resources.ShopRoom;
            ToNorth.RigidBody = null;
            ToEast.RigidBody = null;
            ToWest.RigidBody = null;
            ToSouth.RigidBody = null;
            //addNPC(new NPC("Merchant May",30,30,));

        }
    }
}

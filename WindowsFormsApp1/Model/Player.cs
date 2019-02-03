using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CastleBetaForm.Model.Rooms;
using CastleBetaForm.Properties;

namespace CastleBetaForm.Model
{
    public class Player
    {
        public int helper = 0;

        public int ID { get; set; }
        public string Name { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private Inventory Inventory { get; set; }
        public AbstractRoom CurrentRoom { get; set; }
        AbstractRoom SpawnPoint { get; set; }
        public decimal LocationX { get; set; }
        public decimal LocationY { get; set; }
        public decimal Speed { get; set; }
        public bool ISMoving { get; set; }
        public MoveDest Movedest { get; set; } //Направление игрока
        public RigidBodyRec RigidBody { get; set; }
        //Stats //lvl,Hp,Exp,Mana,Gold
        //StatsofPower:STR,INT,AGI

        public Player(AbstractRoom spawnPoint, int x, int y)
        {
            RigidBody = new RigidBodyRec(LocationX, LocationY, 30, 60);//size of player
            SpawnPoint = spawnPoint;
            CurrentRoom = SpawnPoint;
            LocationX = x;
            LocationY = y;

            Speed = (decimal)10;

            ISMoving = false;
          

        }


        //Move is going by line y=kx;
        public void MoveTo(int x, int y,bool isMoving)
        {
            
            if ((LocationX == x) && (LocationY == y))
            {
                return;
            }
            // Движение по прямой 
            if (!isMoving)
            {
                ISMoving = true;
                if (Math.Abs(x - LocationX) > Math.Abs(y - LocationY))
                {
                    decimal k = (y - LocationY) / (LocationX - x);


                    if ((int)LocationY == y)
                    {
                        if (LocationX > x)
                        {
                            while (LocationX < x)
                            {
                                LocationX -= Speed;
                                RigidBody.LocationX = this.LocationX;
                                RigidBody.LocationY = this.LocationY;
                                Thread.Sleep(20);

                                Movedest = MoveDest.MoveLEFT;
                            }
                        }
                        else
                        {
                            while (LocationX > x)
                            {
                                LocationX += Speed;
                                RigidBody.LocationX = this.LocationX;
                                RigidBody.LocationY = this.LocationY;
                                Thread.Sleep(20);
                                
                                Movedest = MoveDest.MoveRIGHT;
                            }

                        }

                    }
                    else if (LocationX < x)
                    {
                        while ((LocationX < x) && (LocationY != y))
                        {

                            LocationX += Speed;
                            LocationY = (k * (x - LocationX)) + y;
                            RigidBody.LocationX = this.LocationX;
                            RigidBody.LocationY = this.LocationY;
                            Thread.Sleep(20);

                            Movedest = MoveDest.MoveRIGHT;
                        }
                    }
                    else if (LocationX > x)
                    {
                        while ((LocationX > x) && (LocationY != y))
                        {

                            LocationX -= Speed;
                            LocationY = (k * (x - LocationX)) + y;
                            RigidBody.LocationX = this.LocationX;
                            RigidBody.LocationY = this.LocationY;
                            Thread.Sleep(20);

                            Movedest = MoveDest.MoveLEFT;
                        }

                    }

                }
                else
                {
                    decimal k = (x - LocationX) / (LocationY - y);



                    if ((int)LocationX == x)
                    {
                        if (LocationY > y)
                        {
                            while (LocationY > y)
                            {
                                LocationY -= Speed;
                                RigidBody.LocationX = this.LocationX;
                                RigidBody.LocationY = this.LocationY;
                                Thread.Sleep(20);

                                Movedest = MoveDest.MoveUP;
                            }
                        }
                        else
                        {
                            while (LocationY < y)
                            {
                                LocationY += Speed;
                                RigidBody.LocationX = this.LocationX;
                                RigidBody.LocationY = this.LocationY;
                                Thread.Sleep(20);
                                Movedest = MoveDest.MoveDOWN;
                            }
                        }

                    }
                    else if (LocationY < y)
                    {
                        while ((LocationY < y) && (LocationX != x))
                        {

                            LocationY += Speed;
                            LocationX = (k * (y - LocationY)) + x;
                            RigidBody.LocationX = this.LocationX;
                            RigidBody.LocationY = this.LocationY;
                            Thread.Sleep(20);
                            Movedest = MoveDest.MoveDOWN;
                        }
                    }

                    else if (LocationY > y)
                    {
                        while ((LocationY >y) && (LocationX != x))
                        {
                            LocationY -= Speed;
                            LocationX = (k * (y - LocationY)) + x;
                            RigidBody.LocationX = this.LocationX;
                            RigidBody.LocationY = this.LocationY;
                            Thread.Sleep(20);

                            Movedest = MoveDest.MoveUP;
                        }

                    }

                }

            }
            
        }
       
       

        public enum  MoveDest
        {
            MoveUP,
            MoveRIGHT,
            MoveDOWN,
            MoveLEFT
        }

        public void CheckedDest(ref int xhelper, ref int yhelper)
        {
            if (Movedest == Player.MoveDest.MoveUP)
            {

                if (ISMoving)
                {
                    if (helper == 0)
                    {
                        yhelper = 14;
                        xhelper = 9;
                        helper++;
                    }
                    else
                    if (helper == 1)
                    {
                        yhelper = 12;
                        xhelper = 56;
                        helper++;
                    }
                    else
                    if (helper == 2)
                    {
                        yhelper = 14;
                        xhelper = 104;
                        helper ++;
                    }else
                    if (helper == 3)
                    {
                        yhelper = 12;
                        xhelper = 56;
                        helper=0;
                    }
                }

            }
            else

            if (Movedest == Player.MoveDest.MoveRIGHT)
            {

                if (ISMoving)
                {
                    if (helper == 0)
                    {
                        yhelper = 78;
                        xhelper = 9;
                        helper++;
                    }
                    else
                    if (helper == 1)
                    {
                        yhelper = 77;
                        xhelper = 59;
                        helper++;
                    }
                    else
                    if (helper == 2)
                    {
                        yhelper = 79;
                        xhelper = 107;
                        helper ++;
                    }
                    else
                    if (helper == 3)
                    {
                        yhelper = 77;
                        xhelper = 59;
                        helper=0;
                    }
                }

            }
            else
            if (Movedest == Player.MoveDest.MoveDOWN)
            {

                if (ISMoving)
                {
                    if (helper == 0)
                    {
                        yhelper = 139;
                        xhelper = 8;
                        helper++;
                    }
                    else
                    if (helper == 1)
                    {
                        yhelper = 137;
                        xhelper = 56;
                        helper++;
                    }
                    else
                    if (helper == 2)
                    {
                        yhelper = 139;
                        xhelper = 105;
                        helper ++;
                    }
                    else
                    if (helper == 3)
                    {
                        yhelper = 137;
                        xhelper = 56;
                        helper=0;
                    }
                }

            }
            else
            if (Movedest == Player.MoveDest.MoveLEFT)
            {

                if (ISMoving)
                {
                    if (helper == 0)
                    {
                        yhelper = 207;
                        xhelper = 10;
                        helper++;
                    }
                    else
                    if (helper == 1)
                    {
                        yhelper = 205;
                        xhelper = 60;
                        helper++;
                    }
                    else
                    if (helper == 2)
                    {
                        yhelper = 206;
                        xhelper = 108;
                        helper ++;
                    }
                    else
                    if (helper == 3)
                    {
                        yhelper = 205;
                        xhelper = 60;
                        helper=0;
                    }
                }

            }
        }
    }
}

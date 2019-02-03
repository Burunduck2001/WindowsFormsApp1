using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CastleBetaForm.Model
{
    public abstract class AbstractMob
    {
        int helper = 0;

        public int ID { get; set; }
        public string Name { get; set; }
        List<AbstractItem> Loot { get; set; } //Loot from mob
        int Difficulty { get; set; } // (stats depend on it)
        int minDamage { get; set; }
        int maxDamage { get; set;}
        int Cooldown { get; set; }
        public decimal LocationX { get; set; }
        public decimal LocationY { get; set; }
        public decimal Speed { get; set; }
        public MoveDest Movedest = MoveDest.MoveDOWN;
        public List<int> CoordsOfImage { get; set; }
        public int WidthOfImage { get; set; }
        public int HeightOfImage { get; set; }
        Random rng = new Random(DateTime.Now.Millisecond);
        public Bitmap Skin { get; set; }
        public bool IsMoving { get; set; }
        public RigidBodyRec RigidBody { get; set; }
        //Stats //Hp,Exp,Mana,Gold
        //StatsofPower:STR,INT,AGI

        public enum MoveDest
        {
            MoveUP,
            MoveRIGHT,
            MoveDOWN,
            MoveLEFT
        }

        public void MoveTo(int x, int y, int maxX, int maxY)
        {
            

            if ((LocationX == x) && (LocationY == y))
            {
                return;
            }
            // Движение по прямой 
        
            if (!IsMoving)
            {
                IsMoving = true;
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
                                Thread.Sleep(20);

                                Movedest = MoveDest.MoveLEFT;
                            }
                        }
                        else
                        {
                            while (LocationX > x)
                            {
                                LocationX += Speed;
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
                                Thread.Sleep(20);

                                Movedest = MoveDest.MoveUP;
                            }
                        }
                        else
                        {
                            while (LocationY < y)
                            {
                                LocationY += Speed;
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
                            Thread.Sleep(20);
                            Movedest = MoveDest.MoveDOWN;
                        }
                    }

                    else if (LocationY > y)
                    {
                        while ((LocationY > y) && (LocationX != x))
                        {
                            LocationY -= Speed;
                            LocationX = (k * (y - LocationY)) + x;
                            Thread.Sleep(20);

                            Movedest = MoveDest.MoveUP;
                        }

                    }

                }
                IsMoving = false;

            }

            RigidBody.LocationX = this.LocationX;
            RigidBody.LocationY = this.LocationY;



        }

        public void CheckedDest(ref int xhelper, ref int yhelper)
        {
            if (Movedest == AbstractMob.MoveDest.MoveUP)
            {

                if (helper == 0)
                {
                    xhelper = CoordsOfImage[0];
                    yhelper = CoordsOfImage[1];
                    helper++;
                }
                else
                if (helper == 1)
                {
                    xhelper = CoordsOfImage[2];
                    yhelper = CoordsOfImage[3];
                    helper++;
                }
                else
                if (helper == 2)
                {
                    xhelper = CoordsOfImage[4];
                    yhelper = CoordsOfImage[5];
                    helper++;
                }
                else
                if (helper == 3)
                {
                    xhelper = CoordsOfImage[6];
                    yhelper = CoordsOfImage[7];
                    helper = 0;
                }
            }
            else

            if (Movedest == AbstractMob.MoveDest.MoveRIGHT)
            {

                {
                    if (helper == 0)
                    {
                        xhelper = CoordsOfImage[8];
                        yhelper = CoordsOfImage[9];
                        helper++;
                    }
                    else
                    if (helper == 1)
                    {
                        xhelper = CoordsOfImage[10];
                        yhelper = CoordsOfImage[11];
                        helper++;
                    }
                    else
                    if (helper == 2)
                    {
                        xhelper = CoordsOfImage[12];
                        yhelper = CoordsOfImage[13];
                        helper++;
                    }
                    else
                    if (helper == 3)
                    {
                        xhelper = CoordsOfImage[14];
                        yhelper = CoordsOfImage[15];
                        helper = 0;
                    }
                }
            }
            else
            if (Movedest == AbstractMob.MoveDest.MoveDOWN)
            {

                if (helper == 0)
                {
                    xhelper = CoordsOfImage[16];
                    yhelper = CoordsOfImage[17];
                    helper++;
                }
                else
                if (helper == 1)
                {
                    xhelper = CoordsOfImage[18];
                    yhelper = CoordsOfImage[19];
                    helper++;
                }
                else
                if (helper == 2)
                {
                    xhelper = CoordsOfImage[20];
                    yhelper = CoordsOfImage[21];
                    helper++;
                }
                else
                if (helper == 3)
                {
                    xhelper = CoordsOfImage[22];
                    yhelper = CoordsOfImage[23];
                    helper = 0;
                }


            }
            else
            if (Movedest == AbstractMob.MoveDest.MoveLEFT)
            {

                if (helper == 0)
                {
                    xhelper = CoordsOfImage[24];
                    yhelper = CoordsOfImage[25];
                    helper++;
                }
                else
                if (helper == 1)
                {
                    xhelper = CoordsOfImage[26];
                    yhelper = CoordsOfImage[27];
                    helper++;
                }
                else
                if (helper == 2)
                {
                    xhelper = CoordsOfImage[28];
                    yhelper = CoordsOfImage[29];
                    helper++;
                }
                else
                if (helper == 3)
                {
                    xhelper = CoordsOfImage[30];
                    yhelper = CoordsOfImage[31];
                    helper = 0;
                }
            }

            }

        public int RandomX(int min, int max)
        {
            Thread.Sleep(1); //Из-за рандома
            return rng.Next(min, max);
           
        }

        public int RandomY(int min, int max)
        {
            Thread.Sleep(1); //Из-за рандома
            return rng.Next(min, max);
        }

        public AbstractMob()
        {
            Thread.Sleep(1); //Из-за рандома
            IsMoving = false;
        }
    }

}

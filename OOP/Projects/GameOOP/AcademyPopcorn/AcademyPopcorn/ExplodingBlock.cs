using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyPopcorn
{
    //Task 10
    class ExplodingBlock : Block
    {
        public new const string CollisionGroupString = "explodingBlock";

        private bool isActive = false;

        public ExplodingBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = 'Ø';
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (isActive)
            {
                //Add in every possible direction
                List<Shrapnel> shrapnels = new List<Shrapnel>();
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(0, 1)));
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(0, -1)));
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(1, 1)));
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(1, -1)));
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(1, 0)));
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(-1, 0)));
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(-1, -1)));
                shrapnels.Add(new Shrapnel(this.TopLeft, new char[,] { { '¤' } }, new MatrixCoords(-1, 1)));
         
                return shrapnels;
            }
            else
            {
                return base.ProduceObjects();
            }
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            isActive = true;
            ProduceObjects();
        }
    }
}
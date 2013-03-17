using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //Task 11
    class Gift : MovingObject
    {
        public const char Symbol = 'G';
        public new const string CollisionGroupString = "gift";
        private static MatrixCoords VectorDown = new MatrixCoords(1, 0);

        public Gift(MatrixCoords topLeft) : base(topLeft, new char[,] { { 'G' } }, VectorDown)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            //Can only collide woth racket and nothing else
            return otherCollisionGroupString == Racket.CollisionGroupString;
        }
        
        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains(Racket.CollisionGroupString))
            {
                this.IsDestroyed = true; 
            }
        }
    }
}
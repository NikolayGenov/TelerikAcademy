using System;

namespace AcademyPopcorn
{
    //Task 13
    public class Bullet : MovingObject
    {
        public static MatrixCoords VectorUp = new MatrixCoords(-1, 0);

        public Bullet(MatrixCoords topLeft) : base(topLeft, new char[,] { { '^' } }, VectorUp)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            //Can only collide woth racket and nothing else
            return otherCollisionGroupString == Block.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains(Block.CollisionGroupString))
            {
                this.IsDestroyed = true;
            }
        }

        public override string GetCollisionGroupString()
        {
            return Ball.CollisionGroupString;
        }
    }
}
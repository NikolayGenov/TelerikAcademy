using System;

namespace AcademyPopcorn
{
    //Task 8
    class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, speed)
        {
            this.body[0, 0] = '0';
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains(Racket.CollisionGroupString) ||
                collisionData.hitObjectsCollisionGroupStrings.Contains(UnpassableBlock.CollisionGroupString))
            {
                base.RespondToCollision(collisionData);
            }
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Block.CollisionGroupString ||
                   otherCollisionGroupString == Racket.CollisionGroupString ||
                   otherCollisionGroupString == IndestructibleBlock.CollisionGroupString ||
                   otherCollisionGroupString == UnpassableBlock.CollisionGroupString ;
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }
    }
}
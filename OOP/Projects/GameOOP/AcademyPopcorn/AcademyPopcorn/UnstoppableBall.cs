using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
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
            return otherCollisionGroupString == "block" ||
                otherCollisionGroupString == "racket" ||
                   otherCollisionGroupString == "indestructibleBlock" ||
                   otherCollisionGroupString == "unpassableBlock" ;
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }
    }
}
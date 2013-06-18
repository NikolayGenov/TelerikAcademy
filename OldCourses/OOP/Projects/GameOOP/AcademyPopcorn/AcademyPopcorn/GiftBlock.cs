using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyPopcorn
{
    //Task 12
    class GiftBlock : Block
    {
        public GiftBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = '▲';
        }
       
        public override IEnumerable<GameObject> ProduceObjects()
        {
            //If the this block is destroyed we "launch" our gift 
            if (this.IsDestroyed)
            {
                return new List<Gift> { new Gift(this.TopLeft) };
            }
            else
            {
                return base.ProduceObjects();
            }
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
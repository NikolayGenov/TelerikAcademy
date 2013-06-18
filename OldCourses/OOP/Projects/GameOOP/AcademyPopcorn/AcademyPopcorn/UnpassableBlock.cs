using System;


namespace AcademyPopcorn
{
    //Task 8
    class UnpassableBlock : Block
    {
        public const char Symbol = 'X';
        public new const string CollisionGroupString = "unpassableBlock";

        public UnpassableBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = UnpassableBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
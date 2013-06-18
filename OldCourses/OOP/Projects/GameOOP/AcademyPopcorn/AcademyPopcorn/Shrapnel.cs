using System;


namespace AcademyPopcorn
{
    //Using that for task 10 
    class Shrapnel : MovingObject
    {
        public Shrapnel(MatrixCoords topLeft, char[,] body, MatrixCoords speed) : base(topLeft, body, speed)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Block.CollisionGroupString;
        }

        public override string GetCollisionGroupString()
        {
            return Ball.CollisionGroupString;
        }

        public override void Update()
        {
            this.IsDestroyed = true;
        }
    }
}
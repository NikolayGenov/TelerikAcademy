using System;
using System.Collections.Generic;
using System.Linq;


namespace AcademyPopcorn
{
    //Task 11
    class Gift : MovingObject
    {
        public const char Symbol = 'G';
        public new const string CollisionGroupString = "gift";
        private static readonly MatrixCoords vectorDown = new MatrixCoords(1, 0);

        public Gift(MatrixCoords topLeft) : base(topLeft, new char[,] { { 'G' } }, vectorDown)
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
                ProduceObjects();
            }
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                MatrixCoords positionOfTheRacket = new MatrixCoords(topLeft.Row + 1, topLeft.Col - 5);
                List<GameObject> listOfObjects = new List<GameObject>();
                listOfObjects.Add(new ShootingRacket(positionOfTheRacket, 7));
                //Msg for adding +1 to the width and how to shoot 
                listOfObjects.Add(new TrailObject(new MatrixCoords(0, 0), new char[,] { { 'B', 'o', 'n', 'u', 's', ' ', '+', '1' } }, 20));
                listOfObjects.Add(new TrailObject(new MatrixCoords(1, 0), new char[,] { { 'S', 'h', 'o', 'o', 't', ' ', 'w', 'i', 't', 'h', ' ', '\'', 's', 'p', 'a', 'c', 'e', '\'' } }, 20));

                return listOfObjects;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
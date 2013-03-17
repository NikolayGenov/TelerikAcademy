using System;
using System.Collections.Generic;

namespace AcademyPopcorn
{ 
    //Task 13
    class ShootingRacket : Racket
    {
        public bool HasProducedShot = false;

        public ShootingRacket(MatrixCoords topLeft, int width) : base(topLeft, width)
        {
        }

        public void ProduceShot()
        {
            this.HasProducedShot = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.HasProducedShot)
            {
                List<GameObject> bullets = new List<GameObject>();
                bullets.Add(new Bullet(new MatrixCoords(topLeft.Row, topLeft.Col + 3)));
                HasProducedShot = false;
                return bullets;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //Task 6
    class MeteoriteBall : Ball
    {
        readonly int trailLife = 3;

        public int TrailLife { get; private set; }

        private readonly char[,] tailChar = { { '*' } };

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, speed)
        {
            this.TrailLife = trailLife;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> listOfTail = new List<TrailObject>();
            TrailObject partOfTheTail = new TrailObject(this.TopLeft, this.tailChar, this.TrailLife);
            listOfTail.Add(partOfTheTail);
            return listOfTail;
        }
    }
}
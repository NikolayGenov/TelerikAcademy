using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    //Task 5
    class TrailObject : GameObject 
    {
        public int Lifetime { get; private set; }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifetime) : base(topLeft, body)
        {
            this.Lifetime = lifetime;
        }
        
        public override void Update()
        {
            Lifetime--;
            if (Lifetime == 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
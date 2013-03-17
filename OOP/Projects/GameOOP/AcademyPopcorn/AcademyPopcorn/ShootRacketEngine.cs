using System;

namespace AcademyPopcorn
{
    public class ShootRacketEngine : Engine
    { 
        //Task 4
        public ShootRacketEngine(IRenderer renderer, IUserInterface userInterface, int timeToSleep) : base(renderer, userInterface, timeToSleep)
        {
        }

        //Task 13
        public void ShootPlayerRacket()
        {
            if (this.playerRacket is ShootingRacket)
            {
                (this.playerRacket as ShootingRacket).ProduceShot();
            }
        }
    }
}
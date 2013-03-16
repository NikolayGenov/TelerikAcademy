using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }
            //Sides
            for (int i = startCol; i < endCol; i++)
            {
                //Start from 0 where is the start of the matrix
                Block indeBlock = new IndestructibleBlock(new MatrixCoords(i, 0));

                engine.AddObject(indeBlock);
            }
            for (int i = startCol; i < endCol; i++)
            {
                Block indeBlock = new IndestructibleBlock(new MatrixCoords(i, endCol));

                engine.AddObject(indeBlock);
            }
            for (int i = startCol - 1; i < endCol; i++)
            {
                //Check that again
                Block indeBlock = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));

                engine.AddObject(indeBlock);
            }
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);
           
            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            int timeToSleep = 200;
            Engine gameEngine = new Engine(renderer, keyboard, timeToSleep);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
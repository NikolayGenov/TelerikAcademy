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
            for (int i = startCol; i < endCol; i++)
            {
                //Adding a ExplodingBlock aka bomb here
                if (i == 18)
                {
                    ExplodingBlock bomb = new ExplodingBlock(new MatrixCoords(startRow + 1, i));
                    engine.AddObject(bomb);
                    continue;
                }
                Block currBlock = new Block(new MatrixCoords(startRow + 1, i));
                engine.AddObject(currBlock);
            }
            //Task 1
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
                Block indeBlock = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));

                engine.AddObject(indeBlock);
            }
            //End of task 1

            //Task 5
            char[,] startChar = { { 'M', 'o', 'v', 'e', ' ', 'w', 'i', 't', 'h', ' ', '\'', 'a', '\'', ' ', 'a', 'n', 'd', ' ', '\'', 'd', '\'' } };
            TrailObject startMsg = new TrailObject(new MatrixCoords(0, 0), startChar, 20);
            engine.AddObject(startMsg);
            //End of Task 5

            //Task 7
            Ball theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            engine.AddObject(theBall);
            //End of task 7

            //Task 9  - UnpassableBlock added
            for (int i = startCol + 5; i < endCol-17; i++)
            {
                Block unpassBlock = new UnpassableBlock(new MatrixCoords(startRow + 9, i));

                engine.AddObject(unpassBlock);
            }
            
            //Adding unstoppable Ball to the game at some position
            //When the ball destroys more than it should - it's from the colision detection
            Ball unstopBall = new UnstoppableBall(new MatrixCoords(20,  5),
                new MatrixCoords(-1, 1));
            engine.AddObject(unstopBall);
            //End of task 9

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            int timeToSleep = 200;                                                   //Task 2
            Engine gameEngine = new Engine(renderer, keyboard, timeToSleep);         //Task 2

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
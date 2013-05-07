using System;

public class SimpleMathExam : Exam
{
    private const int MAX_PROBLEMS_SOLVED = 10;
    private int problemsSolved;
    
    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            if (value < 0 || value > MAX_PROBLEMS_SOLVED)
            {
                throw new ArgumentOutOfRangeException("Problems solved are out of range - (0,10)");
            }
            this.problemsSolved = value;
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Good result: nothing done.");
        }

        return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
    }
}
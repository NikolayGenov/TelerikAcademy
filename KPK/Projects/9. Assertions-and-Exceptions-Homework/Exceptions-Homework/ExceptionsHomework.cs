using System;
using System.Collections.Generic;

namespace Exceptions_Homework
{
    class ExceptionsHomework
    {
        static void Main()
        {
            var substr = StringUtils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = StringUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = StringUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = StringUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(StringUtils.ExtractEnding("I love C#", 2));
            Console.WriteLine(StringUtils.ExtractEnding("Nakov", 4));
            Console.WriteLine(StringUtils.ExtractEnding("beer", 4));
            try
            {
                Console.WriteLine(StringUtils.ExtractEnding("Hi", 100));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Count is more than the length of the string");
            }

            Console.WriteLine("23 is prime ? -> {0}", MathUtils.IsPrime(23));

            Console.WriteLine("33 is prime? -> {0}", MathUtils.IsPrime(33));

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
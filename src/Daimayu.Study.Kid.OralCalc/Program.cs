using System;
using System.Collections.Generic;

namespace Daimayu.Study.Kid.OralCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose question type number :");
            Console.WriteLine("[1]: X * ( ) ><= Y");
            int.TryParse(Console.ReadLine(), out var type);
            Console.WriteLine("Input question count :");
            int.TryParse(Console.ReadLine(), out var count);
            var qs = GetQuestions((QuestionType) type, count);
            qs.ForEach(c =>
            {
                Console.Write(c + "     ");
            });
        }

        private enum QuestionType
        {
            CompareType1 = 1,
            CompareType2 = 2
        }

        private static List<string> GetQuestions(QuestionType type, int count)
        {
            return type switch
            {
                QuestionType.CompareType1 => GetCompareQuestion(count),
                QuestionType.CompareType2 => GetCompareQuestion(count),
                _ => new List<string>()
            };
        }

        private static List<string> GetCompareQuestion(int count)
        {
            var questions = new List<string>();
            var ops = new string[] { ">", "<", "=" };
            for (var i = 0; i < count; i++)
            {
              var f=  new Random().Next(1, 9);
              var r = new Random().Next(1, 90);
              var o = new Random().Next(0,2);
              questions.Add($"{f} x ( ) {ops[o]} {r}");
            }
            return questions;
        }
    }
}

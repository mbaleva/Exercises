using System;

namespace DateModifierExercise
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifierExercise dateModifier = new DateModifierExercise();
            var result = dateModifier.GetDaysDifference(firstDate,secondDate);

            Console.WriteLine(Math.Abs(result));
        }
    }
}

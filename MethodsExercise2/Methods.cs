using System;
namespace MethodsExercise2
{
    public class Methods
    {
        public static int Add(params int[] values)
        {
            int sum = 0;
            foreach (var number in values)
            {
                sum += number;
            }
            return sum;
        }

        public static int Subtract(params int[] values)
        {
            int sum = 0;
            foreach (var number in values)
            {
                sum -= number;
            }
            return sum;
        }

        public static int Multiply(params int[] values)
        {
            int sum = 1;
            foreach (var number in values)
            {
                sum *= number;
            }
            return sum;
        }

        public static int Divide(params int[] values)
        {
            int sum = values[0];
            foreach (var number in values [1..])
            {
                sum /= number;
            }
            return sum;
        }

    }
}

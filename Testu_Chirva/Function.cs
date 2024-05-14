using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Function_of_testing
    {
        // Функція обчислення факторіалу
        public int CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Число повинно бути невід'ємним.");

            if (number == 0 || number == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        // Функція перевірки парності числа
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Функція перевірки простоти числа
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // Функція знаходження максимального числа у масиві
        public int FindMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім.");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        // Функція знаходження середнього значення у масиві чисел
        public double FindAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Масив не може бути порожнім.");

            return numbers.Average();
        }

        // Функція перевірки належності елемента до масиву
        public bool Contains(int[] numbers, int value)
        {
            if (numbers == null)
                throw new ArgumentException("Масив не може бути null.");

            return numbers.Contains(value);

        }

        // Функція конкатенації двох рядків
        public string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }

        // Функція перевірки паліндрома
        public bool IsPalindrome(string str)
        {

            char[] charArray = str.ToCharArray();


            int i = 0;
            int j = charArray.Length - 1;


            while (i < j)
            {

                if (charArray[i] != charArray[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }

        // Функція обчислення суми чисел у масиві
        public int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // Функція знаходження медіани масиву чисел:
        public double CalculateMedian(int[] numbers)
        {
            Array.Sort(numbers);
            int length = numbers.Length;
            if (length % 2 == 0)
            {

                return (double)(numbers[length / 2 - 1] + numbers[length / 2]) / 2;
            }
            else
            {

                return (double)numbers[length / 2];
            }
        }
    }
}

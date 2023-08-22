namespace Imperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ввод дынных */
            Console.WriteLine("Введите числа пробел, после последнего числа нажмите клавишу {Enter}");
            /*------------*/


            /*Инцилизация переменных*/
            string str = Console.ReadLine() + " "; // + " " так как в переводе конвертации мы добавляем число в случае пробела
            List<int> numbers = new List<int>();
            string digitstring = "";
            /*------------*/


            /*Конвертирование строки чисел в list*/
            foreach (char digitchar in str)
            {
                if (digitchar != ' ')
                {
                    digitstring += digitchar.ToString();
                } else
                {
                    numbers.Add(int.Parse(digitstring));
                    digitstring = "";
                }
                
            }
            /*------------*/


            /*Сортиврока массива пузырьком*/
            for (int i = 0; i < numbers.Count(); i++)
            {
                for (int j = 0; j < numbers.Count(); j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int tempnum = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tempnum;
                    }
                }

            }
            /*------------*/


            /* Вывод массива */
            Console.WriteLine("Эти же числа, но отсортированные:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            /*------------*/
        }
    }
}
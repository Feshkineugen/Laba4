using System;
class Program
{
    public static int N, t ;
    public static void Main()
    {
      int[] Count = new int[16];//Обьявление массива SMS голосов
      int[] Names = new int[16];//Обьявление массива пар

        for (int i = 0; i < 16; i++) //Инициализация массивов
        {
            Count[i] = 0;
            Names[i] = i + 1;
        }
         Console.WriteLine("Введите количество SMS сообщений :");
         N = Int32.Parse(Console.ReadLine());
        if (N < 100)//Ограничение SMS
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Введите номер пары :");
                t = Int32.Parse(Console.ReadLine()) - 1;//Индексация в массиве начинается с нуля, соответственно последний элемент будет иметь индекс N-1
                Count[t] = Count[t] + 1;
            }

            for (int i = 15; i > 0; i--) //Сортировка элементов массивов
                for (int j = 1; j < i; j++)
                    if (Count[j - 1] < Count[j])
                    {
                        t = Count[j]; Count[j] = Count[j - 1]; Count[j - 1] = t;
                        t = Names[j]; Names[j] = Names[j - 1]; Names[j - 1] = t;
                    }
            for (int i = 0; i < 16; i++)//Вывод списка пар и голосов
            {
                if (Count[i] > 0)
                    Console.WriteLine("Номер пары, количество голосов :" + Names[i] + " " + Count[i]);
            }
        }
        else
        {
            Console.WriteLine("Введите количество SMS меньше 100");
            
        }
    }
}

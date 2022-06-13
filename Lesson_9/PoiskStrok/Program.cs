using System;
namespace PoiskStrok
{
    public class Program
    {
        public static void Main()
        {
            var spisokStrok = new List<string>();

            spisokStrok.Add("Ночь, улица, фонарь, аптека,");
            spisokStrok.Add("Бессмысленный и тусклый свет.");
            spisokStrok.Add("Живи еще хоть четверть века —");
            spisokStrok.Add("Всё будет так. Исхода нет.");
            spisokStrok.Add("Умрешь — начнешь опять сначала");
            spisokStrok.Add("И повторится всё, как встарь:");
            spisokStrok.Add("Ночь, ледяная рябь канала,");
            spisokStrok.Add("Аптека, улица, фонарь.");

            var p = new StringSearcher(spisokStrok);

            p.Equal += Handler.Message;
            p.Search(spisokStrok);

            Console.WriteLine("\nОтменить дальнейшую генерацию событий в обработчике? y/n");
            var b = Console.ReadKey();
            Console.WriteLine();


            if (b.GetHashCode() == 5832825)
            {
                p.Equal -= Handler.Message;
                Console.WriteLine("Событие не сгенерировано, т.к. отключен обработчик");
            }
            p.Search(spisokStrok);

            Console.ReadLine();

        }
    }
}
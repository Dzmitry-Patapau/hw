namespace ConsoleAppTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Объявление переменных
            string fullName = "Большевиков Илья Иванович";
            int age = 20;
            string email = "ilia@test.ru";
            float programmingScore = 85.5f;
            float mathScore = 90.0f;
            float physicsScore = 88.5f;

            // Вывод информации на экран
            Console.WriteLine("Студент: {0}", fullName);
            Console.WriteLine("Возраст: {0}", age);
            Console.WriteLine("Email: {0}", email);
            Console.WriteLine("Баллы по программированию: {0}", programmingScore);
            Console.WriteLine("Баллы по математике: {0}", mathScore);
            Console.WriteLine("Баллы по физике: {0}", physicsScore);

            Console.WriteLine("Нажмите любую клавишу для подсчета и вывода суммы баллов и среднего балла...");
            Console.ReadKey();

            // Подсчет суммы баллов
            float totalScore = programmingScore + mathScore + physicsScore;

            // Расчет среднего балла
            float averageScore = totalScore / 3;

            // Вывод суммы баллов и среднего балла на экран
            Console.WriteLine("Сумма баллов по всем предметам: {0}", totalScore);
            Console.WriteLine("Средний балл: {0:F2}", averageScore);

            // Ожидание нажатия любой клавиши перед завершением
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();

        }
    }
}
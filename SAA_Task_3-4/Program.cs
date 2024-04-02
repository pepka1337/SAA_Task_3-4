// See https://aka.ms/new-console-template for more information
using System;



class Program
{
    static int playerHealth = 800; // Здоровье теневого мага
    static int bossHealth = 500;   // Здоровье босса

    static void Main()
    {
        Console.WriteLine("Вы – теневой маг. У вас есть несколько могущественных заклинаний для победы над Боссом!");

        while (playerHealth > 0 && bossHealth > 0)
        {
            DisplayStatus();

            Console.WriteLine("Выберите заклинание:");
            Console.WriteLine("1. Рашамон - призывает теневого духа для нанесения атаки (Отнимает 100 хп игроку)");
            Console.WriteLine("2. Хуганзакура - (Может быть выполнен только после призыва теневого духа), наносит 100 ед. урона");
            Console.WriteLine("3. Межпространственный разлом - позволяет скрыться в разломе и восстановить 250 хп. Урон босса по вам не проходит ");
            Console.WriteLine("4. Теневой клинок - Маг создает клинок из тьмы, нанося 350 ед. урона боссу");
            Console.WriteLine("5. Заклинание теневой побег - Маг убегает от босса на некоторое время и восстанавливает здоровье");
            Console.WriteLine("5. Волшебная пощёчина - Вы даёте боссу пощёчину");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Rashamon();
                    break;
                case 2:
                    if (playerHealth < 400)
                    {
                        Console.WriteLine("Хуганзакура может быть выполнен только после призыва теневого духа.");
                        Console.WriteLine("Выберите другое заклинание.");
                    }
                    else
                    {
                        Huganzakura();
                    }
                    break;
                case 3:
                    InterdimensionalRift();
                    break;
                case 4:
                    ShadowKnife();
                    break;
                case 5:
                    RunOut();
                    break;
                case 6:
                    Shilk();
                    break;

                default:
                    Console.WriteLine("Неверный выбор. Выберите снова.");
                    break;
                
            }

            BossAttack();
        }

        if (playerHealth <= 0)
        {
            Console.WriteLine("Вы пали в битве... Босс победил.");
        }
        else
        {
            Console.WriteLine("Босс повержен! Поздравляем с победой!");
        }
    }

    static void DisplayStatus()
    {
        Console.WriteLine("\nЗдоровье игрока: " + playerHealth);
        Console.WriteLine("Здоровье босса: " + bossHealth + "\n");
    }

    static void Rashamon()
    {
        Console.WriteLine("Вы призвали теневого духа для атаки...");
        playerHealth -= 100;
    }

    static void Huganzakura()
    {
        Console.WriteLine("Вы успешно исполнили Хуганзакура и нанесли 100 ед. урона!");
        bossHealth -= 100;
    }

    static void InterdimensionalRift()
    {
        Console.WriteLine("Вы скрылись в межпространственном разломе и восстановили 250 ед. здоровья.");
        playerHealth += 250;
    }

    static void BossAttack()
    {
        int bossDamage = new Random().Next(50, 150);
        Console.WriteLine("Босс атакует! Наносит " + bossDamage + " ед. урона!");
        playerHealth -= bossDamage;
    }
    static void ShadowKnife()
    {
        Console.WriteLine("Вы успешно нанесли удар теневого клинка 350 ед. урона!");
        bossHealth -= 350;
    }
    static void RunOut()
    {
        Console.WriteLine("Вы успешно убежали от босса и восстановили 150 ед. здоровья");
        playerHealth += 150;
    }
    static void Shilk()
    {
        Console.WriteLine("Вы успешно нанесли пощечину на 50 ед. урона ");
        bossHealth -= 50;
    }
}

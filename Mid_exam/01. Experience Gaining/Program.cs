using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            double experience = 0;
            double gainedExperience = 0;
            int battlesCount = 0;

            for (int i = 0;  battlesCount < battles; i++)
            {
                battlesCount++;
                experience = double.Parse(Console.ReadLine());

                if (battlesCount == 3 || battlesCount == 6 || battlesCount == 9)
                {
                    experience = experience + (experience * 0.15);
                    gainedExperience += experience;
                }
                else if (battlesCount == 5 || battlesCount == 10 || battlesCount == 15)
                {
                    experience = experience - (experience * 0.1);
                    gainedExperience += experience;
                }
                else if (battlesCount == 15 || battlesCount == 30)
                {
                    experience = experience + (experience * 0.05);
                    gainedExperience += experience;
                }
                else
                {
                    gainedExperience += experience;
                }


                if (gainedExperience >= neededExperience)
                { 
                    break;
                }

            }

            if (gainedExperience >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battles} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience - gainedExperience:f2} more needed.");
            }
        }
    }
}
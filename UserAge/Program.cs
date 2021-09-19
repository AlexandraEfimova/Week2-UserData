using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis
            //"oled sündinud aastal {yearOfBirth}"

            Console.WriteLine("Palun, sisesta oma vanus:");
            int UserAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - UserAge;

            Console.WriteLine("Oled sündinud " + yearOfBirth + " aastal.");
                
        }
    }
}

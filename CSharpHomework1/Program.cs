using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace CSharpHomework1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FamilyMembers GrandFatherOne = new FamilyMembers()
            {
                FullName = "Иванов Иван Иванович",
                Age = 50,
                Gender = Gender.man
            };

            FamilyMembers GrandFatherSecond = new FamilyMembers()
            {
                FullName = "Иванов Петр Петрович ",
                Age = 51,
                Gender = Gender.man
            };

            FamilyMembers GrandMotherOne = new FamilyMembers()
            {
                FullName = "Петрова Мария Дмитриевна ",
                Age = 60,
                Gender = Gender.woman
            };

            FamilyMembers GrandMotherSecond = new FamilyMembers()
            {
                FullName = "Смирнова Екатрина Ивановна ",
                Age = 48,
                Gender = Gender.woman
            };

            FamilyMembers Mother = new FamilyMembers()
            {
                FullName = "Петрова Вера Ивановна ",
                Age = 30,
                Gender = Gender.woman,
                Father = GrandFatherSecond,
                Mother = GrandMotherSecond
            };

            FamilyMembers Father = new FamilyMembers()
            {
                FullName = "Петрова Кирилл Иванович ",
                Age = 35,
                Gender = Gender.man,
                Father = GrandFatherOne,
                Mother = GrandMotherOne,
            };

            FamilyMembers Son = new FamilyMembers()
            {
                FullName = "Петров Аркадий Кириллович ",
                Age = 16,
                Gender = Gender.man,
                Mother = Mother,
                Father = Father
            };

            var GrandMothers = Son.GetGrandMotherName();

            var MotherFamily = Mother.GetMothersFamily();

            var FatherFamily = Father.GetFathersFamily();

            Console.WriteLine($"Фио: {Mother.FullName} \nФио матери: {MotherFamily[0]?.FullName} \nФио отца: {MotherFamily[1]?.FullName}");

            Console.WriteLine();

            Console.WriteLine($"Фио: {Father.FullName} \nФио матери: {FatherFamily[0]?.FullName} \nФио отца: {FatherFamily[1]?.FullName}");
        }
    }
}

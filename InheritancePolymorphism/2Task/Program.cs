using System.Text;

namespace _2Task
{
    /*Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
     * Потрібно: Створити клас, який представляє навчальний клас ClassRoom. Створіть клас учень Pupil. 
     * У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). 
     * Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і перевизначте кожен із методів, 
     * залежно від успішності учня. Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів. 
     * Передбачте можливість, що користувач може передати 2 або 3 аргументи. Виведіть інформацію про те, 
     * як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Pupil pupil1 = new ExcellentPupil();
            //Pupil pupil1 = new GoodPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            Pupil pupil4 = new Pupil();
            //Pupil[] pupils = new Pupil[] {pupil1, pupil2, pupil3};
            Pupil[] pupils = new Pupil[] {pupil2, pupil4, pupil1,pupil3 };
            ClassRoom classRoom = new ClassRoom(pupils);
            classRoom.ShowPupilAbilities();
        }
    }
}

using System.Xml.Linq;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 5, 10);
            point.MoveBy(5,2,0.5d);
            Console.WriteLine(point.Text());

            User user = new User("Ivanov", "Ivan", "Ivanovich",32);
            user.Snfa();
        }
    }
}
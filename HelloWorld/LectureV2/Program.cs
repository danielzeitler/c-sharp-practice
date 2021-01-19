using System;

namespace LectureV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 20);
            point.Move(null);
            Console.WriteLine("point is at {0}, {1}", point.x, point.y);
        
        }
    }
}
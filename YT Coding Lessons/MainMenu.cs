using System;
using System.Collections.Generic;
using System.Text;

namespace YT_Coding_Lessons
{
    class MainMenu
    {
        public void Start()
        {
            HelloWorld();

            Lesson1.Shape();
        }
        public void HelloWorld()
        {
            Console.WriteLine("Starting the Program!");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
        }
    }
}

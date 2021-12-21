using System;

namespace ClassIntroduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //

            Lesson lesson1 = new Lesson();
            lesson1.LessonName = "Lesson 1";
            lesson1.LessonInstructor = "Instructor 1";
            lesson1.LessonRating = 100;

            Lesson lesson2 = new Lesson();
            lesson2.LessonName = "Lesson 2";
            lesson2.LessonInstructor = "Instructor 2";
            lesson2.LessonRating = 80;

            Lesson lesson3 = new Lesson();
            lesson3.LessonName = "Lesson 3";
            lesson3.LessonInstructor = "Instructor 3";
            lesson3.LessonRating = 85;

            //Console.WriteLine(lesson1.LessonName + ": " + lesson1.LessonInstructor);

            Lesson[] lessons = new Lesson[] { lesson1, lesson2, lesson3 };

            //Lesson can be "var" aswell.
            foreach (Lesson lesson in lessons)
            {
                Console.WriteLine(lesson.LessonName + ": " + lesson.LessonInstructor);
            }

            //
        }
    }

    class Lesson
    {
        public string LessonName { get; set; }
        public string LessonInstructor { get; set; }
        public int LessonRating { get; set; }
    }

}

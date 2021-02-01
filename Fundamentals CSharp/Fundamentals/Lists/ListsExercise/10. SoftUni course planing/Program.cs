using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_course_planing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduleOfLessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string bum = Console.ReadLine();

                if (bum=="course start")
                {
                    for (int i = 0; i < scheduleOfLessons.Count; i++)
                    {
                        int n = i;
                        Console.WriteLine($"{n+1}.{scheduleOfLessons[i]}");
                    }
                    break;
                }
                string[] command = bum.Split(":", StringSplitOptions.RemoveEmptyEntries);
                if (command[0]=="Add")
                {
                    AddLesson(scheduleOfLessons, command);
                }
                else if (command[0]=="Insert")
                {
                    InsertLesson(scheduleOfLessons, command);
                }
                else if (command[0]=="Remove")
                {
                    RemoveLesson(scheduleOfLessons, command);
                }
                else if (command[0]=="Swap")
                {
                    SwapLessons(scheduleOfLessons, command);
                }
                else if (command[0]=="Exercise")
                {
                    InsertExercise(scheduleOfLessons, command);
                }
            }

        }
        static List<string> AddLesson(List<string> lessonsSchedule, string[] command)
        {
            string lesson = command[1];

            if (!lessonsSchedule.Contains(lesson))
            {
                lessonsSchedule.Add(lesson);
            }
            return lessonsSchedule;
        }
        static List<string> InsertLesson(List<string> lessonsSchedule, string[] command)
        {
            int index = int.Parse(command[2]);
            string lessonsTitle = command[1];
            if (!lessonsSchedule.Contains(lessonsTitle))
            {
                lessonsSchedule.Insert(index, lessonsTitle);
            }
            return lessonsSchedule;
        }
        static List<string> RemoveLesson(List<string> lessonsSchedule, string[] command)
        {
            string lessonTitle = command[1];
            int index = lessonsSchedule.IndexOf(lessonTitle);
            lessonsSchedule.Remove(lessonTitle);
            if (lessonsSchedule.Contains($"{lessonTitle} - Exercise"))
            {
                lessonsSchedule.RemoveAt(index + 1);
            }
            
            
            return lessonsSchedule;
        }
        static List<string> SwapLessons(List<string> lessonsSchedule, string[] command)
        {
            string firstLessonTitle = command[1];
            string secondLessonTitle = command[2];

            if (lessonsSchedule.Contains(firstLessonTitle) && lessonsSchedule.Contains(secondLessonTitle))
            {
                int firstLessonIndex = 
           lessonsSchedule.IndexOf(firstLessonTitle);
                int secondLessonIndex = 
                    lessonsSchedule.
                    IndexOf(secondLessonTitle);

                if (firstLessonIndex!=-1&&secondLessonIndex!=-1)
                {
                    lessonsSchedule[firstLessonIndex] = secondLessonTitle;
                    lessonsSchedule[secondLessonIndex] = firstLessonTitle;

                    string firstLessonExercise = $"{firstLessonTitle}-Exercise";
                    int indexOfFirstExercise = firstLessonIndex + 1;

                    if (indexOfFirstExercise<lessonsSchedule.Count&&
                        lessonsSchedule[indexOfFirstExercise]==firstLessonExercise)
                    {
                        lessonsSchedule.RemoveAt(indexOfFirstExercise);
                        indexOfFirstExercise = lessonsSchedule.IndexOf(firstLessonTitle+1);
                        lessonsSchedule.Insert(indexOfFirstExercise, firstLessonExercise);
                    }


                    string secondLessonExercise = $"{secondLessonTitle}-Exercise";
                    int indexOfSecondExercise = secondLessonIndex + 1;

                    if (indexOfSecondExercise < lessonsSchedule.Count &&
                        lessonsSchedule[indexOfSecondExercise] == secondLessonExercise)
                    {
                        lessonsSchedule.RemoveAt(indexOfSecondExercise);
                        secondLessonIndex = lessonsSchedule.IndexOf(secondLessonTitle);
                        lessonsSchedule.Insert(secondLessonIndex+1, secondLessonExercise);
                    }
                }

                
                
            }
            
            return lessonsSchedule;
        }
        static List<string> InsertExercise(List<string> lessonsSchedule, string[] command)
        {
            string lessonTitle = command[1];
            if (lessonsSchedule.Contains(lessonTitle)&&lessonsSchedule.Contains($"{lessonTitle}-Exercise"))
            {

            }
            else if (!lessonsSchedule.Contains(lessonTitle))
            {
                lessonsSchedule.Add(lessonTitle);
                lessonsSchedule.Add($"{lessonTitle}-Exercise");
            }
            else
            {
                int exerciseIndex = lessonsSchedule.IndexOf(lessonTitle)+1;
                lessonsSchedule.Insert(exerciseIndex, $"{lessonTitle}-Exercise");
            }
            return lessonsSchedule;
        }
    }
}

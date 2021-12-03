using LibraryLesson5;
using System;

namespace Lesson5array
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            do
            {
                Console.WriteLine($"Enter the job number");
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        {
                            Console.WriteLine($"Task№1");

                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int [] arr = Lesson5.Random(range);
                            int min = arr[0];
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"min = {Lesson5.Task1(arr)}");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine($"Task№2");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"max = {Lesson5.Task2(arr)}");
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine($"Task№3");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"min index = {Lesson5.Task3(arr)}");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Task№4");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"max index = {Lesson5.Task4(arr)}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Task№5");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"{Lesson5.Task5(arr)}");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine($"Task№6");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"");
                            int[] reverse = Lesson5.Task6(arr);
                            for (int i = 0; i < reverse.Length; i++)
                            {
                                Console.Write(reverse[i] + " ");
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine($"Task№7");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"The number of odd elements in the array " +
                                $"= {Lesson5.Task7(arr)}");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine($"Task№8");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"");
                            int[] arrFin = Lesson5.Task8(arr);
                            for (int i = 0; i < arrFin.Length; i++)
                            {
                                Console.Write(arrFin[i] + " ");
                            }

                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine($"Task№9");
                            bool result;
                            int range;
                            do
                            {
                                Console.Write("Enter range =");
                                result = int.TryParse(Console.ReadLine(), out range);
                            } while (!result);

                            int[] arr = Lesson5.Random(range);
                            for (int i = 0; i < range; i++)
                            {
                                Console.Write(arr[i] + " ");
                            }

                            Console.WriteLine($"");

                            int[] arrFin = Lesson5.Task9(arr);
                            for (int i = 0; i < arrFin.Length; i++)
                            {
                                Console.Write(arrFin[i] + " ");
                            }

                            break;
                        }

                }
            } while (userInput != 0);


        }
    }
}

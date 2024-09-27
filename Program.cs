using FileSystemReadAndWrite.Models;

namespace FileSystemReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        public static void DisplayMenu()
        {
            bool[] run = {true};


            while (run[0])
            {
                Console.WriteLine($"\n0.Exit\n" +
                    $"1.Read file\n" +
                    $"2.Write file\n");
                ShowCases(int.Parse(Console.ReadLine()),run);
                
            }
        }

        public static void ShowCases(int choice, bool[] run)
        {
            switch (choice)
            {
                case 0:
                    run[0] = false;
                    break;

                case 1:
                    Read();
                    break;

                case 2: 
                    Write(); 
                    break;

                default:
                    Console.WriteLine("please enter correct choice");
                    break;
            }
        }

        public static void Write()
        {
            Console.WriteLine("Enter your userName");
            string userName = Console.ReadLine();
            WriteFile writeContent = new WriteFile(TakePath(),userName);
            Console.WriteLine(writeContent.WriteFileContent());
        }

        public static void Read()
        {
            ReadFile ReadContent = new ReadFile(TakePath());
            Console.WriteLine(ReadContent.ReadFileContent());
        }
        public static string TakePath()
        {
            Console.WriteLine("Enter the path of the file");
            return Console.ReadLine();
        }

    }
}

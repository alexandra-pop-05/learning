using System.Diagnostics.Contracts;

namespace FileSystem
{
    internal class Program
    {
        public interface IDog
        {

        }
        public interface IAnimal : IDog
        {

        }

        public class Fish : IAnimal { }

        public class Giraffe :  IAnimal
        {

        }
        static void Main(string[] args)
        {

            //open a text file and print its content
            var filePath1 = @"C:\Users\CiprianaPop\Desktop\teme prezentari\ex1.txt";


            /* if (File.Exists(filePath1))
             {
                 using (var fileStream = new StreamReader(filePath1))
                 {
                     string? line;

                     while ((line = fileStream.ReadLine()) != null)
                     {
                         Console.WriteLine(line);
                     }
                 }
             }
             else
             {
                 Console.WriteLine("File not found!");
             }*/

            //or
            if (File.Exists(filePath1))
            {
                var allLines = File.ReadAllLines(filePath1);
                foreach (var line in allLines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found!");
            }


                //open a text file and replace its content with "Hello world!" and save changes

                //using File
                var filePath2 = @"C:\Users\CiprianaPop\Desktop\teme prezentari\ex2.txt";

            string newContent = "Hello world!";
            File.WriteAllText(filePath2, newContent);



            //delete a file from the disk 
            var filePath3 = @"C:\Users\CiprianaPop\Desktop\teme prezentari\ex3.txt";

            if (!File.Exists(filePath3))
            {
                using (var fileStream = File.Create(filePath3));
                
                
            }
            
                File.Delete(filePath3);
           



            //create a text file, write something to it, close the file and append some text to it
            var filePath4 = @"C:\Users\CiprianaPop\Desktop\teme prezentari\ex4.txt";

            if (!File.Exists(filePath4))
            {
                //using (var streamWriter = File.AppendText(filePath4))
                using (var streamWriter = new StreamWriter(filePath4))
                {
                    streamWriter.WriteLine("This is exercise four");
                }

            }
            if (File.Exists(filePath4))
            {
                using (var streamWriter = new StreamWriter(filePath4, append: true))
                {
                    streamWriter.WriteLine("This is some text");
                }
                using (var streamReader = new StreamReader(filePath4))
                {
                    string line;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                    }
                }

            }

            //create a directory named A, create a file named file.txt and another directory inside A named B, move the file to the B directory
            var targetFolder = @"C:\Users\CiprianaPop\Desktop\teme prezentari\FileSystemExercise5\A";
            var destinationFolder = @"C:\Users\CiprianaPop\Desktop\teme prezentari\FileSystemExercise5\A\B";

            var filePath5 = @"C:\Users\CiprianaPop\Desktop\teme prezentari\FileSystemExercise5\A\ex5.txt";
            var A = new DirectoryInfo(targetFolder);
            if (!A.Exists)
            {
                A.Create();
            }
            var B = new DirectoryInfo(destinationFolder);
            if (!B.Exists)
            {
                B.Create();
            }

            if (!File.Exists(filePath5))
            {
                var streamWriter = new StreamWriter(filePath5);
                int number6 = 3;
                int another = (int)number6 ;
                using (streamWriter as IDisposable)
                {
                    streamWriter.WriteLine("This is exercise FIVE");
                }

            }
            else { Console.WriteLine("File already exists!"); }

            //MOVE THE FILE EX5 IN B DIRECTORY
            // Get the file name from the path
         /*   var fileName = Path.GetFileName(filePath5);
            //Console.WriteLine(fileName); // returns ex5.txt
            // Combine the destination directory path and the file name to get the new path
            var newFilePath = Path.Combine(B.FullName, fileName);
            // Move the file to the destination directory
            File.Move(filePath5, newFilePath);
            B.MoveTo(@$"{A}\{B.Name}");
*/

            var fileInfo = new FileInfo(filePath5);
            if (!fileInfo.Exists)
            {
                fileInfo.Create().Dispose();
            }

            fileInfo.MoveTo($@"{destinationFolder}\{fileInfo.Name}");



            //TYPE CONVERSIONS


            //implicit conversion

            int number = 2;
            long bigNumber = number;

            IAnimal animal = new Fish();
            IDog puppy = new Giraffe();
             Fish fish = puppy as Fish;


            //explicit conversion

            long big = 22222;
            //int small = big; --error
            int small = (int)big;

            Giraffe giraffe = (Giraffe)animal;


            //AS OPERATOR
            IAnimal animal2 = new Fish();
            Giraffe giraffe1 = animal2 as Giraffe;

            //IS OPERATOR
            IAnimal animal3 = new Fish();
            bool isGiraffe = animal3 is Giraffe;
            if (animal3 is Giraffe giraffe3)
            {
                Console.WriteLine("fish is a giraffe");
            }
            else { Console.WriteLine("fish is not a giraffe"); }







        }
    }
}

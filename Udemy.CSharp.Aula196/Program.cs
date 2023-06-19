namespace Udemy.CSharp.Aula196
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mathe\OneDrive\Documentos\Projetos C#\Udemy.CSharp.Aula196\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
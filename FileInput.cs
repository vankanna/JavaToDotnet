using System;
using System.IO;

namespace dotnetProject
{
    public class FileInput
    {
        private StreamReader input = null;
        private string fileName;

        public FileInput(string fileName)
        {
            this.fileName = fileName;
            try
            {
                input = new StreamReader(this.fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public void fileRead()
        {
            string line;
            try
            {
                while ((line = input.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public string fileReadLine()
        {
            try
            {
                string line = input.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
                return null;
            }
        }

        public void fileClose()
        {
            if (input != null)
            {
                try
                {
                    input.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
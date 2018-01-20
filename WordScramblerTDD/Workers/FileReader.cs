using System.IO;

namespace WordScramblerTDD
{
    public class FileReader
    {
        public string[] Read(string file)
        {
            string[] fileContent;
            fileContent = File.ReadAllLines(file);

            return fileContent;
        }
    }
}
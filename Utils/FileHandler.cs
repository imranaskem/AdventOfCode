using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Utils
{
    public static class FileHandler
    {
        public static IEnumerable<string> LoadFromFile(string filepath)
        {
            var lines = new HashSet<string>();

            var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            return lines;
        }

        public static string LoadLineFromFile(string filepath)
        {
            var line = File.ReadAllText(filepath).Trim();

            return line;
        }
    }
}

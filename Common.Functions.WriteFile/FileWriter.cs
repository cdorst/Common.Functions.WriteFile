using Common.Functions.CreateDirectory;
using static System.IO.File;
using static System.IO.Path;

namespace Common.Functions.WriteFile
{
    public static class FileWriter
    {
        public static void WriteFile(string directoryPath, string fileName, string content)
        {
            CreateDirectory(directoryPath);
            WriteAllText(Combine(directoryPath, fileName), content);
        }

        public static void WriteFile(string directoryPath, string fileName, byte[] content)
        {
            CreateDirectory(directoryPath);
            WriteAllBytes(Combine(directoryPath, fileName), content);
        }

        private static void CreateDirectory(string path) => DirectoryCreator.Create(path);
    }
}

using static System.IO.Directory;
using static System.IO.Path;
using static System.Guid;
using static System.Environment;
using static System.String;

namespace Tests
{
    internal static class Constants
    {
        public const string Contents = "Hello, world!";
        public const string Name = "TestFile.txt";

        public static readonly byte[] Bytes = { 1, 2, 3, 4 };
        public static readonly string Path = GetPath();

        public static readonly string FullPath = Combine(Path, Name);

        private static string GetPath()
        {
            var directory = GetEnvironmentVariable("APPVEYOR_BUILD_FOLDER");
            return IsNullOrEmpty(directory)
                ? GetPathCombination(GetCurrentDirectory())
                : GetPathCombination(directory);
        }

        private static string GetPathCombination(in string directory)
            => Combine(directory, NewGuid().ToString());
    }
}

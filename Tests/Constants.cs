using static System.IO.Directory;
using static System.IO.Path;
using static System.Guid;

namespace Tests
{
    internal static class Constants
    {
        public const string Contents = "Hello, world!";
        public const string Name = "TestFile.txt";

        public static readonly byte[] Bytes = { 1, 2, 3, 4 };
        public static readonly string Path = Combine(GetCurrentDirectory(), NewGuid().ToString());

        public static readonly string FullPath = Combine(Path, Name);
    }
}

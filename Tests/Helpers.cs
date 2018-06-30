using static Xunit.Assert;
using static Tests.Constants;
using static System.IO.File;
using static Common.Functions.ClearDirectory.DirectoryClearer;

namespace Tests
{
    internal static class Helpers
    {
        public static void Arrange() => Clear(Path);

        public static void AssertFileExists() => True(Exists(FullPath));

        public static void Cleanup()
        {
            Clear(Path);
            System.IO.Directory.Delete(Path);
        }
    }
}

# Common.Functions.WriteFile

Helper for writing files

```csharp
using static System.IO.Directory;
using static System.IO.File;
using static System.IO.Path;

namespace Common.Functions.WriteFile
{
    public static class FileWriter
    {
        public static void WriteFile(in string directoryPath, in string fileName, in string content)
        {
            CreateDirectory(directoryPath);
            WriteAllText(Combine(directoryPath, fileName), content);
        }

        public static void WriteFile(in string directoryPath, in string fileName, in byte[] content)
        {
            CreateDirectory(directoryPath);
            WriteAllBytes(Combine(directoryPath, fileName), content);
        }
    }
}
```

## Usage

```csharp
using static Common.Functions.WriteFile.FileWriter;

public static class Example
{
    public static void Write()
        => WriteFile(@"c:\my\path", "MyFile.txt", "Hello, world!");
}
```
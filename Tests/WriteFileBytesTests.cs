﻿using Xunit;
using static Common.Functions.WriteFile.FileWriter;
using static System.IO.File;
using static Tests.Constants;
using static Tests.Helpers;
using static Xunit.Assert;

namespace Tests
{
    public class WriteFileBytesTests
    {
        [Fact]
        public void WriteFile_Creates_File()
        {
            // Arrange
            Arrange();

            // Act
            WriteFile(Path, Name, Bytes);

            // Assert
            AssertFileExists();

            // Cleanup
            Cleanup();
        }

        [Fact]
        public void Written_File_Has_Given_Contents()
        {
            // Arrange
            Arrange();

            // Act
            WriteFile(Path, Name, Bytes);
            var bytes = ReadAllBytes(FullPath);

            // Assert
            Equal(Bytes, bytes);
        }
    }
}

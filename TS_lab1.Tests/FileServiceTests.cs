using TS_lab1.Core;

namespace TS_lab1;

public class FileServiceTests
{
    [Fact]
    public void TestFileReadFunction()
    {
        IFileService fileService = new FileServiceStub();
        var result = fileService.ReadFile("path/to/file");

        Assert.Equal("StubbedFileContent", result);
    }

    [Fact]
    public void TestFileReadFunctionWithInvalidPath()
    {
        IFileService fileService = new FileServiceStub();
        
        var exception = Assert.Throws<FileNotFoundException>(() => fileService.ReadFile("invalid/path/to/file"));

        Assert.Equal("File not found", exception.Message);
    }
}

public class FileServiceStub : IFileService
{
    public string ReadFile(string path)
    {
        if (path == "invalid/path/to/file")
        {
            throw new FileNotFoundException("File not found");
        }

        return "StubbedFileContent";
    }
}

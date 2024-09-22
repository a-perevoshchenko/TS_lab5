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
}

public class FileServiceStub : IFileService
{
    public string ReadFile(string path) => "StubbedFileContent";
}
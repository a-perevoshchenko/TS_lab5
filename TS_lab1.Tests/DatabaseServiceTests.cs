using Moq;
using TS_lab1.Core;

namespace TS_lab1;

public class DatabaseServiceTests
{
    [Fact]
    public void TestDatabaseReadFunction()
    {
        var mockDatabaseService = new Mock<IDatabaseService>();
        mockDatabaseService.Setup(service => service.ReadData(10)).Returns("MockData");

        var result = mockDatabaseService.Object.ReadData(10);

        Assert.Equal("MockData", result);
    }

    [Fact]
    public void TestDatabaseReadFunctionWithInvalidId()
    {
        var mockDatabaseService = new Mock<IDatabaseService>();
        mockDatabaseService.Setup(service => service.ReadData(It.IsAny<int>()))
            .Throws(new ArgumentException("Invalid ID"));

        var exception = Assert.Throws<ArgumentException>(() => mockDatabaseService.Object.ReadData(-1));

        Assert.Equal("Invalid ID", exception.Message);
    }
}


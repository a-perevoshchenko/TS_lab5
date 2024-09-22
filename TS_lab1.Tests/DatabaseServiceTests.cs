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
}

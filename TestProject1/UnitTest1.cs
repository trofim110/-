using System.Collections.Generic;
using Xunit;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var list = new List<int>() { 1, 2, 3 };
        int a = 1;
        int b = 2;
        int c = 3;

        // Act

        Cycler<int> sss = new Cycler<int>(list);
        sss.GetNext();

        // Assert
        Equals(sss.GetNext(), a);
        Equals(sss.GetNext(), b);
        Equals(sss.GetNext(), c);
        Equals(sss.GetNext(), a);

    }
}
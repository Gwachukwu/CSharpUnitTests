namespace StringLibraryTest;

using UtilityLibraries;

[TestClass]
public class StringLibraryTests
{
    [TestCategory("String Extensions")]
    [TestMethod]
    public void StartsWithUpperShouldReturnTrueIfUpperCase()
    {
        Assert.IsTrue("Hello".StartsWithUpper(), "This should be true");
    }
}
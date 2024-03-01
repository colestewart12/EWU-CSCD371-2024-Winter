using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTests
{
    [TestMethod]
    public void CsvRows_ShouldSkipHeaderAndReturnCorrectLines()
    {
        // Arrange
        var sampleData = new SampleData();

        // Act
        var csvRows = sampleData.CsvRows.Count();

        // Assert
        Assert.AreEqual(50, csvRows);
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_ReturnSortedUniqueStates()
    {
        // Arrange
        var sampleData = new SampleData();

        // Act
        List<string> uniqueStates = sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ToList();

        // Assert
        Assert.AreEqual("AL", uniqueStates[0]);
    }

    [TestMethod]
    public void GetAggregateSortedListOfStatesUsingCsvRows_ReturnListofStates()
    {
        // Arrange
        var sampleData = new SampleData();

        // Act
        string result = sampleData.GetAggregateSortedListOfStatesUsingCsvRows();

        // Assert
        Assert.AreEqual('A', result[0]);
    }
}

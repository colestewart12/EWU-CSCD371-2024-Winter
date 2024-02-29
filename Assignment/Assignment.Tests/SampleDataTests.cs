using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

public class SampleDataTests
{
    [TestMethod]
    public void CsvRows_ShouldSkipHeaderAndReturnCorrectLines()
    {
        // Arrange
        var sampleData = new SampleData();

        // Act
        var csvRows = sampleData.CsvRows;
        var csvRowsCount = sampleData.CsvRows.Count;

        // Assert
        Assert.Equals(49, csvRowsCount);
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_ReturnSortedUniqueStates()
    {
        // Arrange
        var sampleData = new SampleData();

        // Act
        List<string> uniqueStates = sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ToList();

        // Assert
        Assert.Equals("AL", uniqueStates[0]);
    }

    [TestMethod]
    public void GetAggregateSortedListOfStatesUsingCsvRows_ReturnListofStates()
    {
        // Arrange
        var sampleData = new SampleData();

        // Act
        string result = sampleData.GetAggregateSortedListOfStatesUsingCsvRows();

        // Assert
        Assert.Equals("A", result[0]);
    }
}

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
        var uniqueStates = sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ToList();

        // Assert
        Assert.Equals("AL", uniqueStates[0]);
    }
}

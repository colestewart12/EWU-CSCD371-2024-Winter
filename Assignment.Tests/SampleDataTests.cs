using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTests
{
    [TestMethod]
    public void CsvRows_ShouldSkipHeaderAndReturnCorrectLines()
    {
        // Arrange
        SampleData sampleData = new();

        // Act
        int csvRows = sampleData.CsvRows.Count();

        // Assert
        Assert.AreEqual(50, csvRows);
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_ReturnSortedUniqueStates()
    {
        // Arrange
        SampleData sampleData = new();

        // Act
        List<string> uniqueStates = sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ToList();

        // Assert
        Assert.AreEqual("AL", uniqueStates[0]);
    }

    [TestMethod]
    public void GetAggregateSortedListOfStatesUsingCsvRows_ReturnListofStates()
    {
        // Arrange
        SampleData sampleData = new();

        // Act
        string result = sampleData.GetAggregateSortedListOfStatesUsingCsvRows();

        // Assert
        Assert.AreEqual('A', result[0]);
    }

    [TestMethod]
    public void Person_FromCSVRows_SortedByAddress()
    {
        //Arrange
        SampleData sampleData = new();

        //Act
        List<IPerson> people = sampleData.People.ToList();

        //Assert
        Assert.AreEqual(50, people.Count);
        Assert.AreEqual("AL", people[0].Address.State);
        Assert.AreEqual("Mobile", people[0].Address.City);
        Assert.AreEqual("37308", people[0].Address.Zip);
    }

    [TestMethod]
    public void FilterPeopleByEmail_Success()
    {
        //Arrange
        SampleData sampleData = new();

        //Act
        List<(string FirstName, string LastName)> people = sampleData.FilterByEmailAddress(filter => filter == "pjenyns0@state.gov").ToList();

        //Assert
        Assert.AreEqual(1, people.Count);
    }

    [TestMethod]
    public void FilterPeopleByEmailGeneric_Success()
    {
        //Arrange
        SampleData sampleData = new();

        //Act
        List<(string FirstName, string LastName)> people = sampleData.FilterByEmailAddress(filter => filter.Contains(".gov")).ToList();

        //Assert
        Assert.AreEqual(5, people.Count);
    }

    [TestMethod]
    public void GetAggregatedListOfStatesGivenPeopleCollection_ValidPeople_ReturnsList()
    {
        // Arrange
        SampleData sampleData = new();
        List<IPerson> people = sampleData.People.ToList();
        List<string> csvResult = sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ToList();

        // Act
        string result = sampleData.GetAggregateListOfStatesGivenPeopleCollection(people);
        Console.WriteLine(result[0] + "" + result[1]);
        Console.WriteLine(csvResult[0]);

        // Assert
        Assert.AreEqual(csvResult[0], result[0] + "" + result[1]);
    }
}

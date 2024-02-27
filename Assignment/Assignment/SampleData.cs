using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        private readonly string csvFilePath = "People.csv";
        // 1.
        public IEnumerable<string> CsvRows 
        {
            get
            {
                if (!File.Exists(csvFilePath))
                {
                    throw new FileNotFoundException($"File not found: {csvFilePath}");
                }

                using var reader = new StreamReader(csvFilePath);
                // Skip the header row
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line != null)
                    {
                        yield return line;
                    }
                }
            }
        }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows() 
            => throw new NotImplementedException();

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => throw new NotImplementedException();

        // 4.
        public IEnumerable<IPerson> People => throw new NotImplementedException();

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}

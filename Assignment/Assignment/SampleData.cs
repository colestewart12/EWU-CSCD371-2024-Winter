using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                    string? line = reader.ReadLine();
                    if (line != null)
                    {
                        yield return line;
                    }
                }
            }
        }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            return CsvRows
                .Select(row => row.Split(',')[6])
                .Distinct()
                .OrderBy(state => state);
        }

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
        {
            return string.Join(", ", GetUniqueSortedListOfStatesGivenCsvRows());
        }

        // 4.
        public IEnumerable<IPerson> People
        {
            get
            {
                return CsvRows
                    .Select(row =>
                    {
                        var columns = row.Split(',');
                        var address = new Address(columns[4], columns[5], columns[6], columns[7]);
                        return new Person(columns[1], columns[2], address, columns[3]);
                    })
                    .OrderBy(person => person.Address.State)
                    .ThenBy(person => person.Address.City)
                    .ThenBy(person => person.Address.Zip);
            }
        }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter)
        {
            return People
                .Where(person => filter(person.EmailAddress))
                .Select(person => (person.FirstName, person.LastName));
        }

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}

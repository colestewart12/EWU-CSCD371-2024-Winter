using System.Runtime.CompilerServices;
using Xunit;

namespace Logger.Tests;

public class BaseEntityTests
{
    private sealed record class TestEntity : BaseEntity
    {
        public override string Name { get; set; }
        public TestEntity(string name) 
        {
            Name = name;
        }
    }

    [Fact]
    public void BaseEntity_SetName_SuccessfulSet()
    {
        //Arrange
        var testEntity = new TestEntity("Test Name");

        //Act
        ((IEntity)testEntity).Name = "New Name";

        //Assert
        Assert.Equal("New Name", ((IEntity)testEntity).Name);
    }
}

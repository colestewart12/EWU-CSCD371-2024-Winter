using Xunit;

namespace Logger.Tests;

public class BaseEntityTests
{
    private class TestEntity : BaseEntity
    {
        private string _name;

        public TestEntity(Guid id, string name)
        {
            _name = name;
            Id = id;
        }

        protected override string GetName()
        {
            return _name;
        }

        protected override void SetName(string name)
        {
            _name = name;
        }
    }

    [Fact]
    public void BaseEntity_SetId_SuccessfulSet()
    {
        //Arrange
        var entityId = Guid.NewGuid();
        var testEntity = new TestEntity(entityId, "Test Name");

        //Assert
        Assert.Equal(entityId, testEntity.Id);
    }

    [Fact]
    public void BaseEntity_SetName_SuccessfulSet()
    {
        //Arrange
        var entityId = Guid.NewGuid();
        var testEntity = new TestEntity(entityId, "Test Name");

        //Act
        ((IEntity)testEntity).Name = "New Name";

        //Assert
        Assert.Equal("New Name", ((IEntity)testEntity).Name);
    }
}

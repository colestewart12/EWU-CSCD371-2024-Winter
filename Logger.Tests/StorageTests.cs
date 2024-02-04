﻿using Xunit;

namespace Logger.Tests;

public class StorageTests
{
    private sealed class TestEntity : IEntity
    {
        public Guid Id { get; init; }
        public required string Name { get; set; }
    }

    [Fact]
    public void AddandContains_BaseEntity_SuccessfullyAdded()
    {
        //Arrange
        var storage = new Storage();
        var baseEntity = new TestEntity { Id = Guid.NewGuid(), Name = "New Entity" };

        //Act
        storage.Add(baseEntity);

        //Assert
        Assert.True(storage.Contains(baseEntity));
    }

    [Fact]
    public void Remove_BaseEntity_SuccessfullyRemoved()
    {
        //Arrange
        var storage = new Storage();
        var baseEntity = new TestEntity { Id = new Guid(), Name = "New Entity" };

        storage.Add(baseEntity);

        //Act
        storage.Remove(baseEntity);

        //Assert
        Assert.False(storage.Contains(baseEntity));
    }

    [Fact]
    public void Get_BaseEntity_SuccessfulFind()
    {
        //Arrange
        var storage = new Storage();
        var testId = Guid.NewGuid();
        var testEntity = new TestEntity { Id = testId, Name = "New Entity" };
        storage.Add(testEntity);

        //Act
        var returned = storage.Get(testId);

        //Assert
        Assert.Equal(testEntity, returned);
    }

    [Fact]
    public void Get_BaseEntity_NotFound()
    {
        //Arrange
        var storage = new Storage();
        var testId = Guid.NewGuid();

        //Act
        var returned = storage.Get(testId);

        //Assert
        Assert.Null(returned);
    }
}

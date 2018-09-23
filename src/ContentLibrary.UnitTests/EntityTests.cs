using ContentLibrary.Data.Repositories;
using ContentLibrary.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace ContentLibrary.UnitTests
{
    [TestClass]
    public class EntityTests
    {        
        [TestMethod]
        public void CreateWithNullObject_ShouldThrowException()
        {
            Entity entity = null;
            Exception exception = new Exception("Cannot insert null object");

            var mockRepo = new Mock<IEntityRepository>();            
            mockRepo.Setup(m => m.Create(entity)).Throws(exception);            
        }

        [TestMethod]
        public void UpdateWithNullObject_ShouldThrowException()
        {
            Entity entity = null;
            Exception exception = new Exception("Cannot update null object");

            var mockRepo = new Mock<IEntityRepository>();
            mockRepo.Setup(m => m.Update(entity)).Throws(exception);
        }

        [TestMethod]
        public void DeleteWithNullObject_ShouldThrowException()
        {
            Entity entity = null;
            Exception exception = new Exception("Cannot delete null object");

            var mockRepo = new Mock<IEntityRepository>();
            mockRepo.Setup(m => m.Delete(entity)).Throws(exception);
        }

        [TestMethod]
        public void GetByType_ReturnsDataForSelectedType()
        {
            var mockEntity = new Entity
            {
                Id = 1,
                Type = "Test Type",
                Content = "Test Content",
                Created = DateTime.Now
            };

            var mockRepo = new Mock<IEntityRepository>();
            mockRepo.Setup(m => m.GetEntityByType("Test Type")).Equals(mockEntity);
        }
    }
}

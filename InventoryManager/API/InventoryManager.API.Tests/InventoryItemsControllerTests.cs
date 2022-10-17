using FluentValidation.Results;
using InventoryManager.API.Controllers;
using InventoryManager.Application.DTOs;
using InventoryManager.Application.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace InventoryManager.API.Tests
{
    public class InventoryItemsControllerTests
    {
        private InventoryItemsController controller;
        private IInventoryAppService inventoryListMockService;

        [SetUp]
        public void Setup()
        {
            inventoryListMockService = Mock.Of<IInventoryAppService>();
            controller = new InventoryItemsController(inventoryListMockService, Mock.Of<ILogger<InventoryItemsController>>());
        }

        [Test]
        [Description("This is a test for the get method returning ok response")]
        public async Task InventoryListController_Get_ReturnOk()
        {
            //Arrange
            Mock.Get(inventoryListMockService).Setup(x => x.GetAllInventoryItemsAsync()).Returns(Task.Run(() => new List<InventoryItemDTO>() { new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now } }));

            //Act
            var result = await controller.Get();

            //Assert
            Assert.AreEqual(result.Count(), 1);
        }

        [Test]
        [Description("This is a test for the get method throwing an axception and null response")]
        public async Task InventoryListController_Get_ThrowingException()
        {
            //Arrange
            Mock.Get(inventoryListMockService).Setup(x => x.GetAllInventoryItemsAsync()).Throws(new System.Exception());

            //Act
            var result = await controller.Get();

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        [Description("This is a test for the get/id method returning ok response")]
        public async Task InventoryListController_GetId_ReturnOk()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now };
            Mock.Get(inventoryListMockService).Setup(x => x.GetInventoryItemAsync(1)).Returns(Task.Run(() => inventoryItem));

            //Act
            var result = await controller.Get(1);

            //Assert
            Assert.AreEqual(result, inventoryItem);
        }

        [Test]
        [Description("This is a test for the get/id method throwing an axception and null response")]
        public async Task InventoryListController_GetId_ThrowingException()
        {
            //Arrange
            Mock.Get(inventoryListMockService).Setup(x => x.GetInventoryItemAsync(1)).Throws(new System.Exception());

            //Act
            var result = await controller.Get(1);

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        [Description("This is a test for the GetBussinessInventoryItemExample method returning ok response")]
        public void InventoryListController_GetBussinessInventoryItemExample_ReturnOk()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now };
            Mock.Get(inventoryListMockService).Setup(x => x.GetBussinessInventoryItemExample()).Returns(inventoryItem);

            //Act
            var result = controller.GetBussinessInventoryItemExample();

            //Assert
            Assert.AreEqual(result, inventoryItem);
        }

        [Test]
        [Description("This is a test for the GetBussinessInventoryItemExample method throwing an axception and null response")]
        public void InventoryListController_GetGetBussinessInventoryItemExample_ThrowingException()
        {
            //Arrange
            Mock.Get(inventoryListMockService).Setup(x => x.GetBussinessInventoryItemExample()).Throws(new System.Exception());

            //Act
            var result = controller.GetBussinessInventoryItemExample();

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        [Description("This is a test for the Post method returning ok response")]
        public async Task InventoryListController_Post_ReturnOk()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now };
            var expectedResult = new ValidationResult();

            Mock.Get(inventoryListMockService).Setup(x => x.CreateAsync(inventoryItem)).Returns(Task.Run(() => expectedResult));

            //Act
            var result = await controller.Post(inventoryItem);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [Description("This is a test for the Post method throwing an axception and null response")]
        public async Task InventoryListController_Post_ThrowingException()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now };
            string errorDescription = "Error Description";

            ValidationResult expectedResult = new ValidationResult();           
            expectedResult.Errors.Add(new ValidationFailure(string.Empty, errorDescription));

            Mock.Get(inventoryListMockService).Setup(x => x.CreateAsync(inventoryItem)).Throws(new System.Exception(errorDescription));

            //Act
            var result = await controller.Post(inventoryItem);

            //Assert
            Assert.AreEqual(result.Errors.First().ErrorMessage, expectedResult.Errors.First().ErrorMessage);
        }

        [Test]
        [Description("This is a test for the Put method returning ok response")]
        public async Task InventoryListController_Put_ReturnOk()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now };
            var expectedResult = new ValidationResult();
            Mock.Get(inventoryListMockService).Setup(x => x.UpdateAsync(1, inventoryItem)).Returns(Task.Run(() => expectedResult));

            //Act
            var result = await controller.Put(1, inventoryItem);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [Description("This is a test for the Put method throwing an axception and null response")]
        public async Task InventoryListController_Put_ThrowingException()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO()
            {
                Id = 1,
                Name = "Desc",
                ExpirationDate = DateTime.Now
            };

            string errorDescription = "Error Description";

            ValidationResult expectedResult = new ValidationResult();
            expectedResult.Errors.Add(new ValidationFailure(string.Empty, errorDescription));

            Mock.Get(inventoryListMockService).Setup(x => x.UpdateAsync(1, inventoryItem)).Throws(new System.Exception(errorDescription));

            //Act
            var result = await controller.Put(1, inventoryItem);

            //Assert
            Assert.AreEqual(result.Errors.First().ErrorMessage, expectedResult.Errors.First().ErrorMessage);
        }

        [Test]
        [Description("This is a test for the Delete method returning ok response")]
        public async Task InventoryListController_Delete_ReturnOk()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now };
            var expectedResult = new ValidationResult();
            Mock.Get(inventoryListMockService).Setup(x => x.DeleteAsync(1)).Returns(Task.Run(() => expectedResult));

            //Act
            var result = await controller.Delete(1);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [Description("This is a test for the Delete method throwing an axception and null response")]
        public async Task InventoryListController_Delete_ThrowingException()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO()
            {
                Id = 1,
                Name = "Desc",
                ExpirationDate = DateTime.Now
            };

            string errorDescription = "Error Description";

            ValidationResult expectedResult = new ValidationResult();
            expectedResult.Errors.Add(new ValidationFailure(string.Empty, errorDescription));

            Mock.Get(inventoryListMockService).Setup(x => x.DeleteAsync(1)).Throws(new System.Exception(errorDescription));

            //Act
            var result = await controller.Delete(1);

            //Assert
            Assert.AreEqual(result.Errors.First().ErrorMessage, expectedResult.Errors.First().ErrorMessage);
        }

        [Test]
        [Description("This is a test for the Delete method returning ok response")]
        public async Task InventoryListController_DeleteByName_ReturnOk()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO() { Id = 1, Name = "Desc", ExpirationDate = DateTime.Now };
            var expectedResult = new ValidationResult();
            Mock.Get(inventoryListMockService).Setup(x => x.DeleteByNameAsync("Desc")).Returns(Task.Run(() => expectedResult));

            //Act
            var result = await controller.DeleteByName("Desc");

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [Description("This is a test for the Delete method throwing an axception and null response")]
        public async Task InventoryListController_DeleteByName_ThrowingException()
        {
            //Arrange
            var inventoryItem = new InventoryItemDTO()
            {
                Id = 1,
                Name = "Desc",
                ExpirationDate = DateTime.Now
            };

            string errorDescription = "Error Description";

            ValidationResult expectedResult = new ValidationResult();
            expectedResult.Errors.Add(new ValidationFailure(string.Empty, errorDescription));

            Mock.Get(inventoryListMockService).Setup(x => x.DeleteByNameAsync("Desc")).Throws(new System.Exception(errorDescription));

            //Act
            var result = await controller.DeleteByName("Desc");

            //Assert
            Assert.AreEqual(result.Errors.First().ErrorMessage, expectedResult.Errors.First().ErrorMessage);
        }
    }
}
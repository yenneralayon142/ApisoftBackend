using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Presentation.Controllers;
using ServiceContracts;
using Shared.DTO;

namespace ApisoftBackendTests
{
    public class CategoryVehicleControllerTests
    {
        private readonly CategoryVehicleController _controller;
        private readonly Mock<IServiceManager> _mockService;

        public CategoryVehicleControllerTests()
        {
            _mockService = new Mock<IServiceManager>();
            _controller = new CategoryVehicleController(_mockService.Object);
        }

        [Fact]
        public async Task Get_All_CategoryVehicle()
        {
            //Arrange
            var objects = new List<CategoryVehicleDTO>();
            _mockService.Setup(s => s.CategoryVehicleService.GetAll(false));

            //Act
            var result = await _controller.Get();

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var actually = Assert.IsAssignableFrom<IEnumerable<CategoryVehicleDTO>>(okResult.Value);
            Assert.Equal(objects, actually);
            
        }


        [Fact]
        public async Task Get_CategoryVehicle_By_Id()
        {
            //Arrange
            var categoryVehicle = new CategoryVehicleDTO(1, "Grande", "Grandote");
            _mockService.Setup(s => s.CategoryVehicleService.GetById(1, false)).ReturnsAsync(categoryVehicle);

            //Act
            var result = await _controller.GetById(1);

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var actually = Assert.IsAssignableFrom<CategoryVehicleDTO>(okResult.Value);
            Assert.Equal(categoryVehicle, actually);
        }


        [Fact]
        public async Task Route_Post_Create_CategoryVehicle()
        {
            //Arrange
            var model = new CategoryVehicle()
            {
                CategoryVehicleId = 1,
                Name = "Grande",
                Description = "Grandote",
                Status = true
            };
            _mockService.Setup(s => s.CategoryVehicleService.CreateCategoryVehicle(model));

            //Act
            var result = await _controller.Post(model);

            //Assert
            var Okresult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Creado correctamente", Okresult.Value);
            _mockService.Verify(s => s.CategoryVehicleService.CreateCategoryVehicle(model), Times.Once);
            _mockService.Verify(s => s.Save(), Times.Once);
        }

        [Fact]
        public async Task Put_Returns_CategoryVehicle()
        {
            //Arrange
            var model = new CategoryVehicle()
            {
                CategoryVehicleId = 1,
                Name = "Rapido",
                Description = "Mucha velocidad",
                Status = true
            };
            _mockService.Setup(s => s.CategoryVehicleService.UpdateCategoryVehicle(model));

            //Act

            var result = await _controller.Put(model.CategoryVehicleId, model);

            //Assert

            var OkResult = Assert.IsType<CategoryVehicle>(result);
            Assert.Equal(model.CategoryVehicleId, OkResult.CategoryVehicleId);
            Assert.Equal(model.Name, OkResult.Name);
            Assert.Equal(model.Description, OkResult.Description);
            Assert.Equal(model.Status, OkResult.Status);
            _mockService.Verify(s => s.CategoryVehicleService.UpdateCategoryVehicle(model), Times.Once);
            _mockService.Verify(s => s.Save(), Times.Once);
        }

        [Fact]
        public async Task Delete_WithValid_ReturnsOkResult()
        {
            //Arrange
            int id = 1;
            var model = new CategoryVehicle()
            {
                Name = "Rapido",
                Description = "Rapidisimo",
                Status = true
            };
            _mockService.Setup(m => m.CategoryVehicleService.DeleteCategoryVehicle(model));

            //Act
            var result = await _controller.Delete(id, model);

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Eliminado correctamente", okResult.Value);
        }
        
    }
}

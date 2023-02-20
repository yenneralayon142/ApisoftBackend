using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Presentation.Controllers;
using ServiceContracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApisoftBackendTests
{
    public class BrandControllerTests
    {
        private readonly BrandController _controller;
        private readonly Mock<IServiceManager> _mockService;
        private readonly CategoryVehicle _category;

        public BrandControllerTests()
        {
            _mockService= new Mock<IServiceManager>();
            _controller = new BrandController(_mockService.Object);
            _category = new CategoryVehicle()
            {
                CategoryVehicleId = 1,
                Name = "Deportivo",
                Description = "Rapidos",
                Status = true
            };
        }

        [Fact]
        public async Task Get_Returns_BrandDTOs()
        {
            //Arrange
            var brands = new List<BrandDTO>();
            _mockService.Setup(s => s.BrandService.GetAll(false)).ReturnsAsync(brands);

            //Act
            var result = await _controller.Get();

            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            var actually = Assert.IsAssignableFrom<IEnumerable<BrandDTO>>(okresult.Value);
            Assert.Equal(brands, actually);
        }

        [Fact]
        public async Task Get_Brand_By_Id()
        {
            //Arrange
            var brand = new BrandDTO(1, "Ferrari", "Deportivo");
            _mockService.Setup(s => s.BrandService.GetById(1, false)).ReturnsAsync(brand);

            //Act
            var result = await _controller.GetById(1);

            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            var actual = Assert.IsAssignableFrom<BrandDTO>(okresult.Value);
            Assert.Equal(brand, actual);
        }

        [Fact]
        public async Task Route_Post_Create_Brand()
        {
            //Arrange 
            var brand = new Brand()
            {
                BrandId = 1,
                Name = "ferrari",
                Description = "test",
                Status = true,
                CategoryVehicleId = 1                
            };

            _mockService.Setup(s => s.BrandService.CreateBrand(brand));

            //Act
            var result = await _controller.Post(brand);

            //Arrange
            var okresult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Creado correctamente", okresult.Value);
            _mockService.Verify(s => s.BrandService.CreateBrand(brand), Times.Once);
            _mockService.Verify(s => s.Save(), Times.Once);
        }

        [Fact]
        public async Task Route_Put_Edit_Brand()
        {
            //Arrange 
            var brand = new Brand()
            {
                BrandId = 1,
                Name = "ferrari",
                Description = "test",
                Status = true,
                CategoryVehicleId = 1
            };

            _mockService.Setup(s => s.BrandService.UpdateBrand(brand));

            //Act
            var result = await _controller.Put(brand.BrandId, brand);

            //Assert
            var okresult = Assert.IsType<Brand>(result);
            Assert.Equal(brand.Name, okresult.Name);
            Assert.Equal(brand.Description, okresult.Description);
            Assert.Equal(brand.Status, okresult.Status);
            Assert.Equal(brand.CategoryVehicleId, okresult.CategoryVehicleId);
            _mockService.Verify(s => s.BrandService.UpdateBrand(brand), Times.Once);
            _mockService.Verify(s => s.Save(), Times.Once);
        }

        [Fact]
        public async Task Route_Delete_Brand_By_Id()
        {
            //Arrange 
            var brand = new Brand()
            {
                BrandId = 1,
                Name = "ferrari",
                Description = "test",
                Status = true,
                CategoryVehicleId = 1
            };

            _mockService.Setup(s => s.BrandService.DeleteBrand(brand));

            //Act
            var result = await _controller.Delete(1, brand);

            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Eliminado correctamente", okresult.Value);
        }
    }
}

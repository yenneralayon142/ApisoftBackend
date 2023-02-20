
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Presentation.Controllers;
using ServiceContracts;
using Services;
using Shared.DTO;
using System.Runtime.CompilerServices;

namespace ApisoftBackendTests
{
    public class TypeDocumentControllerTests
    {
        private readonly TypeDocumentController _controller;
        private readonly Mock<IServiceManager> _mockService;

        public TypeDocumentControllerTests()
        {
            _mockService = new Mock<IServiceManager>();
            _controller = new TypeDocumentController(_mockService.Object);
        }

        [Fact]
        public async Task Get_Returns_TypeDocumentDTOs()
        {
            // Arrange
            var expectedTypeDocumentDTOs = new List<TypeDocumentDTO>();
            _mockService.Setup(s => s.TypeDocumentService.GetTypeDocumentsDTOs(false)).ReturnsAsync(expectedTypeDocumentDTOs);

            // Act
            var result = await _controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var actualTypeDocumentDTOs = Assert.IsAssignableFrom<IEnumerable<TypeDocumentDTO>>(okResult.Value);
            Assert.Equal(expectedTypeDocumentDTOs, actualTypeDocumentDTOs);
        }

        [Fact]
        public async Task Get_TypeDocument_By_Id()
        {
            //Arrange
            var typeDocument = new TypeDocumentDTO("1", "1");
            _mockService.Setup(s => s.TypeDocumentService.GetByIdDto("1", false)).ReturnsAsync(typeDocument);

            //Act
            var Result = await _controller.GetById("1");

            //Assert
            var Okresult = Assert.IsType<OkObjectResult>(Result);
            var actualTypeDocument = Assert.IsAssignableFrom<TypeDocumentDTO>(Okresult.Value);
            Assert.Equal(typeDocument, actualTypeDocument);

        }

        [Fact]
        public async Task Route_Post_Create_TypeDocument()
        {
            //Arrange
            var model = new TypeDocument()
            {
                Type = "CC",
                Description = "Cedula",
                Status = true
            };

            _mockService.Setup(s => s.TypeDocumentService.CreateTypeDocument(model));

            //Act
            var result = await _controller.Post(model);

            //Assert
            var Okresult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Creado correctamente", Okresult.Value);
            _mockService.Verify(s => s.TypeDocumentService.CreateTypeDocument(model), Times.Once);
            _mockService.Verify(s => s.Save(), Times.Once);

        }

        [Fact]
        public async Task Put_Returns_TypeDocument()
        {
            // Arrange
            var typeDocument = new TypeDocument { Type = "CC", Description = "Cedula" };
            _mockService.Setup(s => s.TypeDocumentService.UpdateTypeDocument(typeDocument));

            // Act
            var result = await _controller.Put(typeDocument.Type.ToString(), typeDocument);

            // Assert
            var typedocumentResult = Assert.IsType<TypeDocument>(result);
            Assert.Equal(typeDocument.Type, typedocumentResult.Type);
            Assert.Equal(typeDocument.Description, typedocumentResult.Description);
            _mockService.Verify(s => s.TypeDocumentService.UpdateTypeDocument(typeDocument), Times.Once);
            _mockService.Verify(s => s.Save(),Times.Once);
        }

        [Fact]
        public async Task Delete_WithValidId_ReturnsOkResult()
        {
            // Arrange
            string id = "1";
            var model = new TypeDocument()
            {
                Type= id,
                Description = "Cedula",
                Status = true
            };
            _mockService.Setup(m => m.TypeDocumentService.DeleteTypeDocument(model));

            // Act
            var result = await _controller.Delete(id, model);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Eliminado correctamente", okResult.Value);
        }

    }


}

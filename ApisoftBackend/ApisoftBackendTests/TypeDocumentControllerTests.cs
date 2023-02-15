
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Presentation.Controllers;
using ServiceContracts;
using Services;
using Shared.DTO;

namespace ApisoftBackendTests
{
    public class TypeDocumentControllerTests
    {


        [Fact]
        public async Task Get_Returns_TypeDocumentDTOs()
        {
            // Arrange
            var mockService = new Mock<IServiceManager>();
            var expectedTypeDocumentDTOs = new List<TypeDocumentDTO>();

            mockService.Setup(s => s.TypeDocumentService.GetTypeDocumentsDTOs(false))
                       .ReturnsAsync(expectedTypeDocumentDTOs);

            var controller = new TypeDocumentController(mockService.Object);

            // Act
            var result = await controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var actualTypeDocumentDTOs = Assert.IsAssignableFrom<IEnumerable<TypeDocumentDTO>>(okResult.Value);
            Assert.Equal(expectedTypeDocumentDTOs, actualTypeDocumentDTOs);
        }

        

        



    }


}

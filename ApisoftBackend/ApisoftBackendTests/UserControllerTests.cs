using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Presentation.Controllers;
using ServiceContracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ApisoftBackendTests
{
    public class UserControllerTests
    {
        private readonly UserController _controller;
        private readonly Mock<IServiceManager> _mockService;

        public UserControllerTests()
        {
            _mockService = new Mock<IServiceManager>();
            _controller = new UserController(_mockService.Object);
        }

        [Fact]
        public async Task Get_All_UsersDTO()
        {
            //Arrange
            var objects =  new List<UserDTO>();
            _mockService.Setup(s => s.UserService.GetAll(false)).ReturnsAsync(objects);

            //Act
            var result = await _controller.Get();

            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            var actually = Assert.IsAssignableFrom<IEnumerable<UserDTO>>(okresult.Value);
            Assert.Equal(objects, actually);
        }

        [Fact]
        public async Task Get_User_By_Id()
        {
            //Arrange
            var user = new UserDTO(1, "Jose", "Gonzalez", "test", "3112332131");
            _mockService.Setup(s => s.UserService.GetById(1, false)).ReturnsAsync(user);
            
            //Act
            var result = await _controller.GetById(1);

            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            var actually = Assert.IsAssignableFrom<UserDTO>(okresult.Value);
            Assert.Equal(user, actually);
        }

        [Fact]
        public async Task Route_Post_Create_User()
        {
            //Arrange
            var typedocument = new TypeDocument()
            {
                Type = "CC",
                Description = "Cedula",
                Status = true
            };

            var user = new User()
            {
                TypeDocument= typedocument,
                DocumentNumU = 1,
                FirstName = "Jose",
                FirstSurname = "Gonzalez",
                Direction = "Test",
                Phone = "3218890909"
            };

            _mockService.Setup(s => s.UserService.CreateUser(user));

            //Act
            var result = await _controller.Post(user);

            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Creado correctamente", okresult.Value);
            _mockService.Verify(s => s.UserService.CreateUser(user), Times.Once);
            _mockService.Verify(s => s.Save(), Times.Once);
        }

        [Fact]
        public async Task Route_Put_Edit_User()
        {
            //Arrange
            var typedocument = new TypeDocument()
            {
                Type = "CC",
                Description = "Cedula",
                Status = true
            };

            var user = new User()
            {
                TypeDocument = typedocument,
                DocumentNumU = 1,
                FirstName = "Jose",
                FirstSurname = "Gonzalez",
                Direction = "Test",
                Phone = "3218890909"
            };

            _mockService.Setup(s => s.UserService.UpdateUser(user));

            //Act
            var resullt = await _controller.Put(user.DocumentNumU.ToString(), user);

            //Assert 
            var okresult = Assert.IsType<User>(resullt);
            Assert.Equal(user.DocumentNumU, okresult.DocumentNumU);
            Assert.Equal(user.FirstName, okresult.FirstName);
            Assert.Equal(user.SecondName, okresult.SecondName);
            Assert.Equal(user.FirstSurname, okresult.FirstSurname);
            Assert.Equal(user.Direction, okresult.Direction);
            Assert.Equal(user.Phone, okresult.Phone);

            _mockService.Verify(s => s.UserService.UpdateUser(user), Times.Once);
            _mockService.Verify(s => s.Save(), Times.Once);
        }

        [Fact]
        public async Task Route_Delete_User()
        {
            var typedocument = new TypeDocument()
            {
                Type = "CC",
                Description = "Cedula",
                Status = true
            };

            var user = new User()
            {
                TypeDocument = typedocument,
                DocumentNumU = 1,
                FirstName = "Jose",
                FirstSurname = "Gonzalez",
                Direction = "Test",
                Phone = "3218890909"
            };

            _mockService.Setup(s => s.UserService.DeleteUser(user));

            //Act
            var result = await _controller.Delete("1", user);

            //Assert
            var okresult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Eliminado correctamente", okresult.Value);
        }
    }
}

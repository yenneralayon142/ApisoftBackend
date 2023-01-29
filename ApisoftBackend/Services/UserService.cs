using AutoMapper;
using Contracts;
using Entities.Models;
using ServiceContracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryWrapper _repository;        
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public UserService(IRepositoryWrapper repository, IMapper mapper, ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
            this._mapper = mapper;
            
        }
        public async Task<IEnumerable<UserDTO>> GetAll(bool trackChanges)
        {
            var users = await _repository.User.GetAllAsync(false);
            var dto = _mapper.Map<IEnumerable<UserDTO>>(users);

            return dto;
        }
        public async Task<UserDTO> GetById(int id, bool trackChanges)
        {
            var user = await _repository.User.GetByIdAsync(id, trackChanges);
            var dto = _mapper.Map<UserDTO>(user);

            return dto;
        }
        public void UpdateUser(User user)
        {
            _repository.User.Update(user);
        }
        public void CreateUser(User user)
        {
            _repository.User.Create(user);
        }
        public void DeleteUser(User user)
        {
            _repository.User.Delete(user);
        }
    }
}

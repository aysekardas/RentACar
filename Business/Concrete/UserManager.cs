using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.User;
using Business.Responses.User;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly UserBusinessRules _userBusinessRules;
        private readonly IMapper _mapper;

        public UserManager(IUserDal userDal, UserBusinessRules userBusinessRules, IMapper mapper)
        {
            _userDal = userDal;
            _userBusinessRules = userBusinessRules;
            _mapper = mapper;
        }

        public AddUserResponse Add(AddUserRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteUserResponse Delete(DeleteUserRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserByIdResponse GetById(GetUserByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserListResponse GetList(GetUserListRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateUserResponse Update(UpdateUserRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

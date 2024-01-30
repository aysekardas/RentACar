using Business.Requests.User;
using Business.Responses.User;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService 
    {

        public AddUserResponse Add(AddUserRequest request);

        public GetUserListResponse GetList(GetUserListRequest request);

        public GetUserByIdResponse GetById(GetUserByIdRequest request);

        public UpdateUserResponse Update(UpdateUserRequest request);
        public DeleteUserResponse Delete(DeleteUserRequest request);
    }
}

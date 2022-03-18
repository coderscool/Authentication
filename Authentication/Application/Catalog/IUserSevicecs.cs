using Authentication.Application.Catalog.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Application.Catalog
{
    public interface IUserSevicecs
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);
    }
}

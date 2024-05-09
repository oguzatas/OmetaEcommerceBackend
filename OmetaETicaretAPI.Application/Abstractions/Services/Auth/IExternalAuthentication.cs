using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaETicaretAPI.Application.Abstractions.Services.Auth
{
    public interface IExternalAuthentication
    {
        Task<DTOs.Token> FacebookLoginAsync(string authToken, int accessTokenLifeTime);
        Task<DTOs.Token> GoogleLoginAsync(string idToken, int accessTokenLifeTime);
    }
}

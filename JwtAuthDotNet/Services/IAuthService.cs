using JwtAuthDotNet.Entities;
using JwtAuthDotNet.Models;

namespace JwtAuthDotNet.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);

        Task<TokenReponseDto?> LoginAsync(UserDto request);

        Task<TokenReponseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
    }
}

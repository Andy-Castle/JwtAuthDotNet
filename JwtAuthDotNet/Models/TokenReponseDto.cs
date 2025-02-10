namespace JwtAuthDotNet.Models
{
    public class TokenReponseDto
    {
        public required string AccessToken { get; set; }

        public required string RefreshToken { get; set; }
    }
}

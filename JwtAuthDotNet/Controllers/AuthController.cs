﻿using JwtAuthDotNet.Entities;
using JwtAuthDotNet.Models;
using JwtAuthDotNet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        public static User user = new();

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var user = await authService.RegisterAsync(request);

            if (user == null)
            {
                return BadRequest("Username already exists");
            }

            return Ok(user);
        }


        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
           var token = await authService.LoginAsync(request);

            if (token == null)
            {
                return Unauthorized("Invalid username or password");
            }

            return Ok(token);
        }
     
    }
}

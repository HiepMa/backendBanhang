﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using BANHANG.Models;
using BANHANG.Models.Login;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BANHANG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;
        public AuthController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("Token")]
        public ActionResult Token(LoginRequest request)
        {
            if (!String.IsNullOrEmpty(request.email) && !String.IsNullOrEmpty(request.pass))
            {
                var user = _context.khachhang.Where(x => x.EMAIL == request.email && x.MATKHAU == request.pass).SingleOrDefault();
                if (user != null)
                {
                    var claimData = new[] { new Claim(ClaimTypes.Name, request.email) };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(request.email + " " + request.pass));
                    var singingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

                    var token = new JwtSecurityToken(
                        issuer: "mysite.com",
                        audience: "mysite.com",
                        expires: DateTime.Now.AddMinutes(20),
                        claims: claimData,
                        signingCredentials: singingCredentials
                        );
                    var tokenstring = new JwtSecurityTokenHandler().WriteToken(token);
                    AES mahoa = new AES();
                    var userResult = new LoginRespone
                    {
                        IDKH = user.IDKH,
                        //MATKHAU = mahoa.EncryptAES(user.MATKHAU),

                        token = "Bearer " + tokenstring
                    };
                    return Ok(userResult);
                }
            }
            return Unauthorized();
        }
    }
}
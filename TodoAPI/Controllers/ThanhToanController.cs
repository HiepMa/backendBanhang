using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BANHANG.Models;
using BANHANG.Models.Reponses;
using BANHANG.Models.Requests;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BANHANG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThanhToanController : ControllerBase
    {
        private readonly DataContext _context;
        public ThanhToanController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult ThanhToan(PaymentRequest tt)
        {
            if (!String.IsNullOrEmpty(tt.SoThe))
            {
                if (!String.IsNullOrEmpty(tt.MaOTP))
                {
                    if(tt.MaOTP == ma)
                    {
                        
                        var kq = new PaymentReponse
                        {
                            flag = true,
                            Sothe = tt.SoThe
                        };
                        return Ok(kq);
                    }
                    else
                    {
                        var kq = new MassengeReponse
                        {
                            Mass = "Sai ma OTP",
                            flag = false
                        };
                        return Ok(kq);
                    }
                }
                else
                {
                    Random rd = new Random();
                    ma = "";
                    for (int i = 0; i < 4; i++)
                    {
                        ma += rd.Next(0, 9).ToString();
                    }
                    return Ok("Ma OTP:" + ma);
                }
            }
            else {
                var kq = new MassengeReponse
                {
                    Mass = "Vui lòng nhập số thẻ",
                    flag = false
                };
                return Ok(kq);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BANHANG.Models.Reponses
{
    public class LoginRespone
    {
        public long IDKH { get; set; }
        public string TENKH { get; set; }
        public string DIACHIKH { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public string Token { get; set; }
    }
}

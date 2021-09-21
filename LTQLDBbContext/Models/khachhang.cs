using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLDBbContext.Models
{
    public class khachhang
    {
        [Key]
        public String  MaKhachHang { get; set; }
        public String TenKhachHang  { get; set; }
    }
}
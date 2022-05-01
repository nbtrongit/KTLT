using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT.Entities;
using KTLT.Services;
using Microsoft.AspNetCore.Http;

namespace KTLT.Pages
{
    public class MH_DangNhapModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string user { get; set; }
        [BindProperty]
        public string password { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            NguoiDung? nd = XuLyNguoiDung.DangNhap(user, password);
            if (nd != null)
            {
                HttpContext.Session.SetString("key", nd.Value.user);
                Response.Redirect("/MH_DanhSachSanPham");
            }
            else
            {
                Chuoi = "Đăng Nhập không thành công";
            }
        }
    }
}

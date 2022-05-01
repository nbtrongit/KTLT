using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT.Services;

namespace KTLT.Pages
{
    public class MH_DangKyModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string user { get; set; }
        [BindProperty]
        public string password { get; set; }
        [BindProperty]
        public string fullname { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            bool kq = XuLyNguoiDung.DangKy(user, password, fullname);
            Chuoi = $"Kết quả: {kq}";
            Response.Redirect("/MH_DanhSachSanPham");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT.Services;

namespace KTLT.Pages
{
    public class MH_TaoSanPhamModel : PageModel
    {
        public string Chuoi;
        [BindProperty]
        public string maSP { get; set; }
        [BindProperty]
        public string tenSP { get; set; }
        [BindProperty]
        public int giaSP { get; set; }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }
        public void OnPost()
        {
            SANPHAM s;
            s.maSanPham = maSP;
            s.tenSanPham = tenSP;
            s.giaSanPham = giaSP;
            bool kq = XuLySanPham.Tao(s);
            Chuoi = $"{kq}";
        }
    }
}

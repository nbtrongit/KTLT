using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT.Services;
using KTLT.Entities;

namespace KTLT.Pages
{
    public class MH_DanhSachSanPhamModel : PageModel
    {
        public List<SANPHAM> danhSachSP;
        public string Chuoi { get; set; }
        [BindProperty]
        public string TuKhoa { get; set; }
        public void OnGet()
        {
            danhSachSP = XuLySanPham.TimKiem(string.Empty);
        }
        public void OnPost()
        {
            danhSachSP = XuLySanPham.TimKiem(TuKhoa);
        }
    }
}

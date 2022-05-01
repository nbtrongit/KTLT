using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KTLT.Entities;
using KTLT.Services;

namespace KTLT.Pages
{
    public class MH_XoaSanPhamModel : PageModel
    {
        public SANPHAM SanPham;
        public string Chuoi;
        public bool coSP;
        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public void OnGet()
        {
            SANPHAM? sp = XuLySanPham.DocSanPham(id);
            if (sp != null)
            {
                SanPham = sp.Value;
                //coSP = true;
            }
            else
            {
                Chuoi = "Không tìm thấy sản phẩm";
            }
            coSP = (sp != null); //không thêm true trong if
        }
        public void OnPost()
        {
            bool kq = XuLySanPham.XoaSanPham(id);
            Chuoi = $"Kết quả là {kq}";
            //quay lại màn hình danh sách sản phẩm
            Response.Redirect("/MH_DanhSachSanPham");
        }
    }
}

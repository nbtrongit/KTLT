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
    public class MH_Tinh_ChuViDaGiacModel : PageModel
    {
        public string kq;
        public DAGIAC d;
        [BindProperty]
        public string ChuoiDaGiac { get; set; }
        public void OnGet()
        {
            kq = string.Empty;
            ChuoiDaGiac = "(3,2)|(4,3)|(1,7)|(2,3)";
            d = XuLyDaGiac.khoiTao(ChuoiDaGiac); //GET mà đa giác chưa có giá trị nên phải khởi tạo
        }
        public void OnPost()
        {
            d = XuLyDaGiac.khoiTao(ChuoiDaGiac);
            kq = $"Kết quả: {XuLyDaGiac.ChuVi(d)}";
        }
    }
}

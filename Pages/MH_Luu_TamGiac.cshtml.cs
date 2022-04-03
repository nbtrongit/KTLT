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
    public class MH_Luu_TamGiacModel : PageModel
    {
        public TAMGIAC t;
        public string kq { get; set; }
        [BindProperty]
        public int X1 { get; set; }
        [BindProperty]
        public int Y1 { get; set; }
        [BindProperty]
        public int X2 { get; set; }
        [BindProperty]
        public int Y2 { get; set; }
        [BindProperty]
        public int X3 { get; set; }
        [BindProperty]
        public int Y3 { get; set; }
        public void OnGet()
        {
            X1 = 0;
            Y1 = 1;
            X2 = 1;
            Y2 = 0;
            X3 = 0;
            Y3 = 0;
            kq = string.Empty;
        }
        public void OnPost()
        {
            t.A.X = X1;
            t.A.Y = Y1;
            t.B.X = X2;
            t.B.Y = Y2;
            t.C.X = X3;
            t.C.Y = Y3;
            kq = $"Kết quả: {XuLyTamGiac.ChuVi(t)}";
        }
    }
}

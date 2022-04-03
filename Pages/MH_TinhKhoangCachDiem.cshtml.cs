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
    public class MH_TinhKhoangCachDiemModel : PageModel
    {
        public DIEM a, b;
        public string kq { get; set; }
        [BindProperty]
        public int X1 { get; set; }
        [BindProperty]
        public int Y1 { get; set; }
        [BindProperty]
        public int X2 { get; set; }
        [BindProperty]
        public int Y2 { get; set; }
        public void OnGet()
        {
            X1 = 0;
            Y1 = 1;
            X2 = 1;
            Y2 = 0;
            kq = string.Empty;
        }
        public void OnPost()
        {
            a.X = X1;
            a.Y = Y1;
            b.X = X2;
            b.Y = Y2;
            kq = $"Kết quả: {XuLyDiem.KhoangCach(a,b)}";
        }
    }
}

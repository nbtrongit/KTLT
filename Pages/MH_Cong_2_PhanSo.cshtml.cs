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
    public class MH_Cong_2_PhanSoModel : PageModel
    {
        public PHANSO a;
        public PHANSO b;
        public string kq { get; set; }
        [BindProperty]
        public int Tu1 { get; set; }
        [BindProperty]
        public int Mau1 { get; set; }
        [BindProperty]
        public int Tu2 { get; set; }
        [BindProperty]
        public int Mau2 { get; set; }
        public void OnGet()
        {
            kq = string.Empty;
        }
        public void OnPost()
        {
            //PHANSO a, b;
            a.TuSo = Tu1;
            a.MauSo = Mau1;
            b.TuSo = Tu2;
            b.MauSo = Mau2;
            PHANSO s = XuLyPhanSo.Tong(a, b);
            kq = $"Kết quả: {s.TuSo}/{s.MauSo}";
        }
    }
}

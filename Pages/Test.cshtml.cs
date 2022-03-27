using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KTLT.Pages
{
    public class TestModel : PageModel
    {
        public string Chuoi { get; set; }
        public int A { get; set; }

        [BindProperty]
        public int X { get; set; }
        public void OnGet()
        {
            Chuoi = "Xin Chào";
            A = 100;
        }
        public void OnPost()
        {
            A = X * 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using KTLT.DAL;

namespace KTLT.Services
{
    public class XuLyTamGiac
    {
        public static double ChuVi(TAMGIAC t)
        {
            double a, b, c;
            a = XuLyDiem.KhoangCach(t.A, t.B);
            b = XuLyDiem.KhoangCach(t.A, t.C);
            c = XuLyDiem.KhoangCach(t.C, t.B);
            return a + b + c;
        }
		public static bool KiemTraTamGiac(TAMGIAC t)
		{
			double a, b, c;
            a = XuLyDiem.KhoangCach(t.A, t.B);
            b = XuLyDiem.KhoangCach(t.A, t.C);
            c = XuLyDiem.KhoangCach(t.C, t.B);
			return a + b > c && a + c > b && b + c > a;
		}
		public static bool LuuTamGiac(TAMGIAC t)
		{
			if(KiemTraTamGiac(t))
            {
				LuuTruTamGiac.Luu(t);
				return true;
			}
			return false;
		}
		public static TAMGIAC DocTamGiac()
		{
			TAMGIAC t;
			t = LuuTruTamGiac.Doc();
			return t;
		}
    }
}

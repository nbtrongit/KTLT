using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using KTLT.DAL;

namespace KTLT.Services
{
    public class XuLyDiem
    {
        public static double KhoangCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
        public static bool LuuDiem(DIEM a)
        {
            LuuTruDiem.Luu(a);
            return true;
        }
		public static DIEM DocDiem()
		{
			DIEM kq;
			kq = LuuTruDiem.Doc();
			return kq;
		}
    }
}

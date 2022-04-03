using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using KTLT.DAL;

namespace KTLT.Services
{
    public class XuLyDaGiac
    {
        public static DAGIAC khoiTao(string ChuoiDaGiac)
        {
            DAGIAC d;
            string[] m = ChuoiDaGiac.Split("|", StringSplitOptions.RemoveEmptyEntries);
            d.DanhSachDinh = new DIEM[m.Length];
            for (int i = 0; i < m.Length; i++)
            {
                d.DanhSachDinh[i] = XuLyDiem.KhoiTao(m[i]);
            }
            return d;
        }
        public static double ChuVi(DAGIAC d)
        {
            double cv = 0;
            for(int i = 0; i < d.DanhSachDinh.Length - 1; i++)
            {
                cv = cv + XuLyDiem.KhoangCach(d.DanhSachDinh[i], d.DanhSachDinh[i + 1]);
            }
            cv = cv + XuLyDiem.KhoangCach(d.DanhSachDinh[d.DanhSachDinh.Length - 1], d.DanhSachDinh[0]);
            return cv;
        }
        public static DAGIAC DocDaGiac()
		{
			DAGIAC d;
			d = LuuTruDaGiac.Doc();
			return d;
		}
    }
}

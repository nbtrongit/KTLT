using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;

namespace KTLT.DAL
{
    public class LuuTruDaGiac
    {
        public static DAGIAC Doc()
		{
			DAGIAC d;
			StreamReader file = StreamReader("C://Users//Trong//OneDrive//Desktop//KTLT//dagiac.txt");
			string s = file.ReadLine();
			d.DanhSachDinh = new DIEM[int.Parse(s)];
			for(int i = 0; i < d.DanhSachDinh.Length; i++)
			{
				s = file.ReadLine();
				d.DanhSachDinh[i] = LuuTruDiem.KhoiTaoDiem(s);
			}
			return d;
		}
    }
}

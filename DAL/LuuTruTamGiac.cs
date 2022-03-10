using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;

namespace KTLT.DAL
{
    public class LuuTruTamGiac
    {
        public static void Luu(TAMGIAC t)
        {
            StreamWriter file = new StreamWriter("C://Users//Trong//OneDrive//Desktop//KTLT//tamgiac.txt");
            file.WriteLine($"{t.A.X},{t.A.Y}");
			file.WriteLine($"{t.B.X},{t.B.Y}");
			file.Write($"{t.C.X},{t.C.Y}");
            file.Close();
        }
		public static TAMGIAC Doc()
		{
			TAMGIAC t;
			StreamReader file = new StreamReader("C://Users//Trong//OneDrive//Desktop//KTLT//tamgiac.txt");
			string s = file.ReadLine();
			t.A = LuuTruDiem.KhoiTaoDiem(s);
			s = file.ReadLine();
			t.B = LuuTruDiem.KhoiTaoDiem(s);
			s = file.ReadLine();
			t.C = LuuTruDiem.KhoiTaoDiem(s);
			return t;
		}
    }
}

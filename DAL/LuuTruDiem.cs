using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;

namespace KTLT.DAL
{
    public class LuuTruDiem
    {
        public static void Luu(DIEM a)
        {
            StreamWriter file = new StreamWriter("C://Users//Trong//OneDrive//Desktop//KTLT//diem.txt");
            file.Write($"{a.X},{a.Y}");
            file.Close();
        }
		public static DIEM Doc()
		{
			DIEM a;
			StreamReader file = new StreamReader("C://Users//Trong//OneDrive//Desktop//KTLT//diem.txt");
			string s = file.ReadLine();
			a = KhoiTaoDiem(s);
			return a;
		}
		public static DIEM KhoiTaoDiem(string s)
		{
			DIEM a;
			string[] m = s.Split(',');
			a.X = int.Parse(m[0]);
			a.Y = int.Parse(m[1]);
			return a;
		}
    }
}

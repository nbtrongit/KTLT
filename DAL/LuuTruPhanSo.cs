using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;

namespace KTLT.DAL
{
    public class LuuTruPhanSo
    {
        public static void Luu(PHANSO a)
        {
            StreamWriter file = new StreamWriter("C://Users//Trong//OneDrive//Desktop//KTLT//phanso.txt");
            file.Write($"{a.TuSo}/{a.MauSo}");
            file.Close();
        }
    }
}

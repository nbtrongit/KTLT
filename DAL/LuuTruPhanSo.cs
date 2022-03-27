using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using Newtonsoft.Json;

namespace KTLT.DAL
{
    public class LuuTruPhanSo
    {
        public static void Luu_File(PHANSO a)
        {
            StreamWriter file = new StreamWriter("C://Users//Trong//OneDrive//Desktop//KTLT//phanso.txt");
            file.Write($"{a.TuSo}/{a.MauSo}");
            file.Close();
        }
        public static void Luu(PHANSO a)
        {
            StreamWriter file = new StreamWriter("C://Users//Trong//OneDrive//Desktop//KTLT//phanso.json");
            string json = JsonConvert.SerializeObject(a);
            file.WriteLine(json);
            file.Close();
        }
        public static DIEM Doc()
        {
            DIEM a;
            StreamReader file = new StreamReader("C://Users//Trong//OneDrive//Desktop//KTLT//phanso.json");
            string json = file.ReadToEnd();
            a = JsonConvert.DeserializeObject<DIEM>(json);
            file.Close();
            return a;
        }
    }
}

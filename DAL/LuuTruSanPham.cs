using KTLT.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KTLT.DAL
{
    public class LuuTruSanPham
    {
        public static bool Luu(SANPHAM s)
        {
            List<SANPHAM> danhSachSP = Doc();
            danhSachSP.Add(s);
            LuuDanhSachSP(danhSachSP);
            return true;
        }
        public static List<SANPHAM> Doc()
        {
            StreamReader reader = new StreamReader("C://Users//Trong//OneDrive//Desktop//KTLT//sanpham.json");
            string json = reader.ReadToEnd();
            reader.Close();
            List<SANPHAM> danhSachSP = JsonConvert.DeserializeObject<List<SANPHAM>>(json);
            return danhSachSP;
        }
        public static bool LuuDanhSachSP(List<SANPHAM> dsSP)
        {
            StreamWriter writer = new StreamWriter("C://Users//Trong//OneDrive//Desktop//KTLT//sanpham.json");
            string json = JsonConvert.SerializeObject(dsSP);
            writer.Write(json);
            writer.Close();
            return true;
        }
        public static bool SuaSanPham(SANPHAM sp)
        {
            List<SANPHAM> dssp = LuuTruSanPham.Doc();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].maSanPham == sp.maSanPham)
                {
                    dssp[i] = sp;
                    LuuTruSanPham.LuuDanhSachSP(dssp);
                    return true;
                }
            }
            return false;
        }
    }
}

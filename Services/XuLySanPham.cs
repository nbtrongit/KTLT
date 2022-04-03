using KTLT.DAL;
using KTLT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT.Services
{
    public class XuLySanPham
    {
        public static bool Tao(SANPHAM s)
        {
            if (string.IsNullOrWhiteSpace(s.maSanPham) || string.IsNullOrWhiteSpace(s.tenSanPham) || s.giaSanPham <= 0)
            {
                return false;
            }
            return LuuTruSanPham.Luu(s);
        }
        public static List<SANPHAM> TimKiem(string tukhoa)
        {
            if(tukhoa == null)
            {
                tukhoa = string.Empty;
            }
            List<SANPHAM> dssp = LuuTruSanPham.Doc();
            List<SANPHAM> kq = new List<SANPHAM>();
            foreach(SANPHAM sp in dssp)
            {
                if(sp.maSanPham.Contains(tukhoa) || sp.tenSanPham.Contains(tukhoa))
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }
    }
}

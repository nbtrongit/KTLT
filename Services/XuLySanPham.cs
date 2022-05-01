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
        public static SANPHAM? DocSanPham(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            List<SANPHAM> dssp = LuuTruSanPham.Doc();
            foreach (SANPHAM sp in dssp)
            {
                if (sp.maSanPham == id)
                {
                    return sp;
                }
            }
            return null;
        }
        public static bool SuaSanPham(string id, string tensp, int giasp)
        {
            if (string.IsNullOrWhiteSpace(tensp) || string.IsNullOrWhiteSpace(id) || giasp <= 0)
            {
                return false;
            }

            SANPHAM? sp = DocSanPham(id);
            if (sp != null)
            {
                SANPHAM spmoi;
                spmoi.maSanPham = id;
                spmoi.tenSanPham = tensp;
                spmoi.giaSanPham = giasp;
                return LuuTruSanPham.SuaSanPham(spmoi);
            }
            return false;
            //nguyên phần này nên tách xuống data layer
            /*List<SANPHAM> dssp = LuuTruSanPham.Doc();
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].maSanPham == id)
                {
                    SANPHAM sp;
                    sp.maSanPham = id;
                    sp.tenSanPham = tensp;
                    sp.giaSanPham = giasp;
                    dssp[i] = sp;
                    LuuTruSanPham.LuuDanhSachSP(dssp);
                    return true;
                }
            }
            return false;*/
        }
        public static bool XoaSanPham(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }
            SANPHAM? sp = DocSanPham(id);
            if (sp != null)
            {
                return LuuTruSanPham.XoaSanPham(id);
            }
            return false;
        }
    }
}

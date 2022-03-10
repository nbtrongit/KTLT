using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using KTLT.DAL;

namespace KTLT.Services
{
    public class XuLyPhanSo
    {
        public static PHANSO Tong(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
        public static bool LuuPhanSo(PHANSO a)
        {
            if(a.MauSo == 0)
            {
                return false;
            }
            LuuTruPhanSo.Luu(a);
            return true;
        }
    }
}

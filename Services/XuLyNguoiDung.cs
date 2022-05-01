using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using KTLT.DAL;

namespace KTLT.Services
{
    public class XuLyNguoiDung
    {
        public static bool DangKy(string user, string password, string fullname)
        {
            if(string.IsNullOrWhiteSpace(user)|| string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(fullname))
            {
                return false;
            }
            NguoiDung? nd = LuuTruNguoiDung.TimNguoiDung(user);
            if(nd != null)
            {
                return false;
            }
            else
            {
                NguoiDung newUser;
                newUser.user = user;
                newUser.pass = password;
                newUser.fullname = fullname;
                return LuuTruNguoiDung.ThemNguoiDung(newUser);
            }
        }
        public static NguoiDung? DangNhap(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                return null;
            }
            NguoiDung? nd = LuuTruNguoiDung.TimNguoiDung(user);
            if(nd != null && nd.Value.pass == pass)
            {
                return nd;
            }
            else
            {
                return null;
            }
        }
    }
}

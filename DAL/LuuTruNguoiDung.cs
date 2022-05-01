using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using System.IO;
using Newtonsoft.Json;

namespace KTLT.DAL
{
    public class LuuTruNguoiDung
    {
        public static bool Luu(List<NguoiDung> dsNguoiDung)
        {
            StreamWriter writer = new StreamWriter("C://Users//Trong//OneDrive//Desktop//KTLT//NguoiDung.json");
            string json = JsonConvert.SerializeObject(dsNguoiDung);
            writer.Write(json);
            writer.Close();
            return true;
        }
        public static List<NguoiDung> Doc()
        {
            StreamReader reader = new StreamReader("C://Users//Trong//OneDrive//Desktop//KTLT//NguoiDung.json");
            string json = reader.ReadToEnd();
            reader.Close();
            List<NguoiDung> danhSachSP = JsonConvert.DeserializeObject<List<NguoiDung>>(json);
            return danhSachSP;
        }
        public static bool ThemNguoiDung(NguoiDung user)
        {
            List<NguoiDung> danhNguoiDung = Doc();
            danhNguoiDung.Add(user);
            Luu(danhNguoiDung);
            return true;
        }
        public static NguoiDung? TimNguoiDung(string tukhoa)
        {
            if (tukhoa == null)
            {
                tukhoa = string.Empty;
            }
            List<NguoiDung> dsNguoiDung = LuuTruNguoiDung.Doc();
            foreach (NguoiDung nd in dsNguoiDung)
            {
                if (nd.user == tukhoa)
                {
                    return nd;
                }
            }
            return null;
        }
    }
}

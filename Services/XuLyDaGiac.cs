using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTLT.Entities;
using KTLT.DAL;

namespace KTLT.Services
{
    public class XuLyDaGiac
    {
        public static DAGIAC DocDaGiac()
		{
			DAGIAC d;
			d = LuuTruDaGiac.Doc();
			return d;
		}
    }
}

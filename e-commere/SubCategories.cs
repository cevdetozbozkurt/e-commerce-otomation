using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commere
{
    internal class SubCategories
    {
        string altKategoriId;
        string altKategoriName;
        string altKategoriDate;
        string kategoriId;

        public string AltKategoriId { get => altKategoriId; set => altKategoriId = value; }
        public string AltKategoriName { get => altKategoriName; set => altKategoriName = value; }
        public string AltKategoriDate { get => altKategoriDate; set => altKategoriDate = value; }
        public string KategoriId { get => kategoriId; set => kategoriId = value; }
    }
}

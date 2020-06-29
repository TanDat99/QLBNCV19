using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBNCV19
{
    
    public class DTO_QLBN
    {
        string hoVaTen, diaChi, hoVaTenBS, tinhTrang,maBN,moTa;
        DateTime ngaySinh;

        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string HoVaTenBS { get => hoVaTenBS; set => hoVaTenBS = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MaBN { get => maBN; set => maBN = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}

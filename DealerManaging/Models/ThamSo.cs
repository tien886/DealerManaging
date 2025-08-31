using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerManaging.Models
{
    public class ThamSo
    {
        [Key]
        public int Id { get; set; } = 0;
        public int SoLuongDaiLyToiDa { get; set; } = 0;
        public bool QuyDinhSoLuongDaiLyToiDa { get; set; } = true;
        public bool QuyDinhTienThuTienNo { get; set; } = true;
    }
}

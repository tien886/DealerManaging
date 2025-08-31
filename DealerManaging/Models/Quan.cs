using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerManaging.Models
{
    public class Quan
    {
        [Key]
        public int MaQuan { get; set; } = 0;

        [Required(ErrorMessage = "Tên quận không được để trống")]
        [StringLength(100, ErrorMessage = "Tên quận không được vượt quá 100 ký tự")]
        public string TenQuan { get; set; } = "";

        // Navigation property
        public ICollection<DaiLy> DsDaiLy { get; set; } = [];
    }
}

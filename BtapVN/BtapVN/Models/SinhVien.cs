using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BtapVN.Models
{
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên là bắt buộc.")]
        public string MaSinhVien { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc.")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Ngày sinh là bắt buộc.")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc.")]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Quê quán là bắt buộc.")]
        public string QueQuan { get; set; }

        [Required(ErrorMessage = "Lớp học là bắt buộc.")]
        public string LopHoc { get; set; }
    }
}
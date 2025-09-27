using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SBSAi5.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Họ tên")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Loại thành viên")]
        public string MembershipType { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Ngày tham gia")]
        public DateTime JoinDate { get; set; }
        [Display(Name = "Trạng thái")]
        public bool IsActive { get; set; }
    }
}
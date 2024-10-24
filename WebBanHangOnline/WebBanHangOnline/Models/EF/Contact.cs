using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    [Table("tb_Contract")]
    public class Contact : CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ten khong de trong ")]
        [StringLength(150, ErrorMessage = "khong vuot 150 ki tu")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(150, ErrorMessage = "khong vuot 150 ki tu")]
        public string Message { get; set; }
        public bool IsRead { get; set; }

    }
}
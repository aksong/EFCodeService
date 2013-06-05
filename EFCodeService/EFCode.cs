using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeService
{
    public class EFCode
    {
        [Key]
        [StringLength(EFCodeService.MaxStringLength)]
        public string Code { get; set; }

    }
}

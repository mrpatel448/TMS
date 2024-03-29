﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    public class CommonLookupModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Type")]
        public string Type { get; set; }

        [Required(ErrorMessage ="Code Is Required")]
        [Display(Name = "Code")]
       
        public string Code { get; set; }


        [Required(ErrorMessage ="Name is Required")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "DisplayOrder")]
        public int DisplayOrder { get; set; }


        [Required]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
        
    }
}

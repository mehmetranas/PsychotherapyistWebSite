﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PsychotherapistWebSite.Models;

namespace PsychotherapistWebSite.Core.ViewModels
{
    public class ServiceViewModel
    {
       public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Alan Adı")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Açıklama")]
        [StringLength(1000)]
        public string Content { get; set; }

        public Image[] Images { get; set; }

        public Image Image1 => Images.Length > 0 ? Images[0] : null;

        public Image Image2 => Images.Length > 1 ? Images[1] : null;

        public string TruncateContent => Content.Length > 35 ? Content.Substring(0, 35) : Content;

        public IEnumerable<Image> AllImages { get; set; }

    }
}
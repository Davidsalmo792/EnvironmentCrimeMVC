using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uppgift1VC.Models.POCO

{
    public class Picture
    {
        public int PictureId { get; set; }
        public string PictureName { get; set; }
        public int ErrandId { get; set; }
    }
}

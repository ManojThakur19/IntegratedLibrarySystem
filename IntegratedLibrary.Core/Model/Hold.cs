using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IntegratedLibrary.Model
{
    public class Hold
    {
        public int Id { get; set; }
        [Required]
        public virtual LibraryAsset LibraryAsset { get; set; }
        [Required]
        public virtual LibraryCard LibraryCard { get; set; }
        public DateTime HoldPlaced { get; set; }
        
    }
}

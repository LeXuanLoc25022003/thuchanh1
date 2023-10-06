using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace thuchanh1.Areas.Admin.Models
{
    [Table("AdminMenu")]
    public class Class
    {
        [Key]
        public long AdminMenuID { get; set; }
        public string? ItemName { get; set; }
        public int ItemLevel { get; set; }  
        public int ParentLevel { get; set; }
        public int ItemOrder { get; set; }
        public bool? IsActive { get; set; }
        public string? ItemTarget { get; set;}
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? Icon { get; set; }
        public string? IdName { get; set; }
    }
}

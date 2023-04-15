using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace InspectionAPI
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;
    }
}

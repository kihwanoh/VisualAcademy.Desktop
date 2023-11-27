using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace VisualAcademy.Desktop.Models
{
    public class AppointmentType
    {
        public int Id {get; set; }
        public string AppointmentTypeName { get; set; }
        public bool IdActive { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}

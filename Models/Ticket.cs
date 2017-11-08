using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISApi.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? SitNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCreated { get; set; }
        public int? MonthCreated { get; set; }
        public int? YearCreated { get; set; }
        public int StatusId { get; set; }
        public bool IsCallBack { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Data.Database
{
    public class Tickets
    {
        [Key]
        public int Id { get; set; }
        public string TicketName { get; set; }
        public string Type { get; set; }
        public string DescriptionData { get; set; }
        public int PriorityID { get; set; }
        public int StatusId { get; set; }
        public string AssignedTo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public string TicketViewId { get; set; }
    }
}

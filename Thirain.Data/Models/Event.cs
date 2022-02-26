﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirain.Data.Models
{
    public class Event : Entity
    {
        
        [Required]
        public long SID { get; set; }
        public string EventCreator { get; set; }
        public string EventBeschreibung { get; set; }
        public DateTime Time { get; set; }

    }
}

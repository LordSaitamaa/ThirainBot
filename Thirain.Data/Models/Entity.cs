﻿using System.ComponentModel.DataAnnotations;

namespace Thirain.Data.Models
{
    public abstract class Entity
    {
        [Key]
        public long Id { get; set; }  
    }
}

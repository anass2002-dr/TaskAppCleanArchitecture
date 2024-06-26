﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskAppCleanArchitecture.Domaine.Models
{
    public class TacheDo
    {
        public int Id { get; set; }
        [Required]
        public string?  Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        [JsonIgnore]
        public TacheStatut? TacheStatut { get; set; }
        public int? idTacheStatut { get; set; }
    }
}

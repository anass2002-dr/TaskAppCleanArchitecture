using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TaskAppCleanArchitecture.Domaine.Models
{
    public class TacheStatut
    {
        public int? Id { get; set; }
        public string? Description { get; set; }=string.Empty;
        public string? statut { get; set; } = string.Empty;
        [JsonIgnore]
        public ICollection<TacheDo>? TacheDo { get; set; }

        //public TacheStatut()
        //{
        //    TaskDo = new HashSet<TacheDo>();
        //}
        
    }
}

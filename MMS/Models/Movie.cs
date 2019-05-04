using System;
using System.Collections.Generic;

namespace MMS.Models
{
    public partial class Movie
    {
        /// <summary>
        /// id will be used for this..
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public double? Length { get; set; }
        public string Language { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Director { get; set; }
        public string LeadActor { get; set; }
        public string LeadActress { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}

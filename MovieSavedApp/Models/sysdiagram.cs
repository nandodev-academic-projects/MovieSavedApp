using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieSavedApp.Models
{
    public partial class sysdiagram
    {
        public string name { get; set; }
        public int principal_id { get; set; }

        [Key]
        public int diagram_id { get; set; }
        public Nullable<int> version { get; set; }
        public byte[] definition { get; set; }
    }
}
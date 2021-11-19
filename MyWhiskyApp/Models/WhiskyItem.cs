using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace MyWhiskyApp.Models
{
    public class WhiskyItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}

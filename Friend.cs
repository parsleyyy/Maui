﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Maui
{
        [Table("Friends")]
        public class Friend
        {
            [PrimaryKey, AutoIncrement, Column("_id")]
            public int Id { get; set; }

            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
}

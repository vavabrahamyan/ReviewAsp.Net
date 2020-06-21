﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationDBApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company  Company { get; set; }
    }
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
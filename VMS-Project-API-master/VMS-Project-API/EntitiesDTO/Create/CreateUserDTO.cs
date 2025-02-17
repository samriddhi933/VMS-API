﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_Project_API.EntitiesDTO.Create
{
    public class CreateUserDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNo { get; set; }
        public string? EmailId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public string? Image { get; set; }
        public bool Status { get; set; } = true;
        public DateTime RegDate { get; set; } = DateTime.Now;
    }
}

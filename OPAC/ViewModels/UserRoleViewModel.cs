using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OPAC.Controllers;
using OPAC.Models;

namespace OPAC.ViewModels
{
    public class UserRoleViewModel
    {
        public User user { get; set; }
        public List<Role> roles { get; set; }
        public List<UserRole> userRoles { get; set; }
        public int[] roleIDList { get; set; }
        public int roleID { get; set; }
        public PaginatedList<User> dataPaging { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OPAC.Controllers;
using OPAC.Models;

namespace OPAC.ViewModels
{
    public class RoleViewModel
    {
        public Role role { get; set; }
        public PaginatedList<Role> dataPaging { get; set; }
    }
}
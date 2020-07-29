using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OPAC.Controllers;
using OPAC.Models;

namespace OPAC.ViewModels
{
    public class TagViewModel
    {
        public Tag tag { get; set; }
        public PaginatedList<Tag> dataPaging { get; set; }
    }
}
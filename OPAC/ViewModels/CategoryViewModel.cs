using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OPAC.Controllers;
using OPAC.Models;

namespace OPAC.ViewModels
{
    public class CategoryViewModel
    {
        public Category category { get; set; }
        public PaginatedList<Category> dataPaging { get; set; }
    }
}
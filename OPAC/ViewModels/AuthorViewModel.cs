using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OPAC.Controllers;
using OPAC.Models;

namespace OPAC.ViewModels
{
    public class AuthorViewModel
    {
        public Author author { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoBase64 { get; set; }
        public PaginatedList<Author> dataPaging { get; set; }
    }
}
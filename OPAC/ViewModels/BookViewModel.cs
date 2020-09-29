using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OPAC.Controllers;
using OPAC.Models;
using OPAC.InlistModels;

namespace OPAC.ViewModels
{
    public class BookViewModel
    {
        public Book book { get; set; }
        public List<Category> categories { get; set; }
        public List<BookCategory> bookCategories { get; set; }
        public BookLearn bookLearns { get; set; }
        public BookRequirement bookRequirements { get; set; }
        public int[] categoryIDList { get; set; }
        public List<Tag> tags { get; set; }
        public List<BookTag> bookTags { get; set; }
        public int[] tagIDList { get; set; }
        public IFormFile FileURL { get; set; }
        public IFormFile Cover { get; set; }
        public int[] BookFlagKey = new int[] { 1, 2 };
        public string[] BookFlagDesc = new string[] { "Internal Only", "Internal & External" };
        public PaginatedList<Catalogs> dataPaging { get; set; }
    }
}
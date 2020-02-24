using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGalery.Models;
using ImageGallery.data.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageGalery.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var mikoImageTags = new List<ImageTag>();
            var rockyImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Description = "Adventure",
                Id = 0
            };

            var tag2 = new ImageTag()
            {
                Description = "Dog",
                Id = 1
            };

            var tag3 = new ImageTag()
            {
                Description = "Lesnica",
                Id = 2
            };

            mikoImageTags.AddRange(new List<ImageTag>{ tag1, tag3 });
            rockyImageTags.Add(tag2);

            var imageList = new List<GalleryImage>() 
            {
                new GalleryImage()
                {
                    Title = "Miko",
                    Url = "",
                    Created = DateTime.Now,
                    Tags = mikoImageTags
                },

                new GalleryImage()
                {
                    Title = "Rocky",
                    Url = "",
                    Created = DateTime.Now,
                    Tags = rockyImageTags
                },

                new GalleryImage()
                {
                    Title = "Miko Park Lesnica",
                    Url = "",
                    Created = DateTime.Now,
                    Tags = mikoImageTags
                }
            };
            var model = new GalleryIndexModel() 
            { 
                Images = imageList
            };

            return View(model);
        }
    }
}
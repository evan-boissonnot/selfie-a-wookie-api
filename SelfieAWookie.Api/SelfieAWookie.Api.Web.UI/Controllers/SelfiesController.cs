using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Api.Core.Models;

namespace SelfieAWookie.Api.Web.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfiesController : ControllerBase
    {
        #region Public methods
        [HttpGet]
        public ActionResult<List<Selfy>> Get()
        {
            List<Selfy> items = new List<Selfy>();

            items.Add(new Selfy()
            {
                Id = 1,
                Date = DateTime.Now,
                Wookie = new Wookie() { Id = 1, Size = 300, Surname = "Chewie" },
                Image = new Image() { Id = 1, Title = "Hey chewie !", Url = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwijh4LP1NDiAhVHzhoKHRCgC8UQjRx6BAgBEAU&url=https%3A%2F%2Fstarwars.fandom.com%2Ffr%2Fwiki%2FWookiee%2FL%25C3%25A9gendes&psig=AOvVaw2la6ZQnJYQL2-0JiexivR3&ust=1559766356228146" },
                Comments = new List<Comment>() {
                    new Comment() { Id = 1, Date = DateTime.Now, Content = "Oh un commentaire", Wookie = new Wookie() { Id = 1, Size = 300, Surname = "Chewie" } },
                    new Comment() { Id = 2, Date = DateTime.Now.AddDays(-2), Content = "Sympa la photo", Wookie = new Wookie() { Id = 2, Size = 200, Surname = "Chewie 2" } } }
            });

            items.Add(new Selfy()
            {
                Id = 2,
                Date = DateTime.Now.AddMonths(-1),
                Wookie = new Wookie() { Id = 2, Size = 200, Surname = "Chewie 2" },
                Image = new Image() { Id = 1, Title = "Wahoo !", Url = "https://static1.squarespace.com/static/57446959356fb03f47441db6/t/590b376a3a04112426069c59/1493907311931/" },
                Comments = new List<Comment>() {
                    new Comment() { Id = 3, Date = DateTime.Now.AddMinutes(-10), Content = "Oh un commentaire 3", Wookie = new Wookie() { Id = 1, Size = 300, Surname = "Chewie" } },
                    new Comment() { Id = 4, Date = DateTime.Now.AddDays(-7), Content = "Oh la tête", Wookie = new Wookie() { Id = 1, Size = 300, Surname = "Chewie" } } }
            });

            return items;
        }
        #endregion
    }
}

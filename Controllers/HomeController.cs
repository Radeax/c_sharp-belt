using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrightIdeas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                // If a User exists with provided email
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    
                    // You may consider returning to the View at this point
                    return View("index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    dbContext.Add(newUser);
                    dbContext.SaveChanges();
                }
            }
            return View("index");
        }
        [HttpPost("/login")]
        public IActionResult Login(LoginUser submission)
        {
            if(ModelState.IsValid)
            {
                var userInDB = dbContext.Users.FirstOrDefault(u => u.Email == submission.Email2);
                if(userInDB == null)
                {
                    ModelState.AddModelError("Email2","Email does not exist");
                    return View("index");
                }

                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(submission, userInDB.Password,submission.Password2);

                if(result == 0)
                {
                    ModelState.AddModelError("Password2","Wrong Password");
                    return View("index");
                }
                else
                {
                    HttpContext.Session.SetString("ID", userInDB.UserId.ToString());
                    return RedirectToAction("home");
                }
            }
            else
            {
                return View("index");
            }
        }

        [Route("/home")]
        public IActionResult Home()
        {
            try
            {
                User current = dbContext.Users.FirstOrDefault(u => u.UserId == int.Parse(HttpContext.Session.GetString("ID")));
                ViewBag.Name = current.Name;
                ViewBag.ID = current.UserId;
            }
            catch
            {
                return RedirectToAction("index");
            }

            IndexModel ideas = new IndexModel();
            ideas.Ideas = dbContext.Ideas.Include(e => e.Creator).Include(e => e.Likes).ThenInclude(u => u.User).ToList();
            return View(ideas);
        }

        [HttpPost("/add")]
        public IActionResult Add(IndexModel modelData)
        {
            Idea newIdea = modelData.NewIdea;
            User current = dbContext.Users.FirstOrDefault(u => u.UserId == int.Parse(HttpContext.Session.GetString("ID")));
            if(ModelState.IsValid)
            {
                // Idea NewIdea = new Idea();
                // NewIdea.Content = newidea.Content;
                newIdea.UserId = current.UserId;
                dbContext.Add(newIdea);
                dbContext.SaveChanges();
                return RedirectToAction("home");
            }
            else
            {
                ViewBag.Name = current.Name;
                ViewBag.ID = current.UserId;

                IndexModel ideas = new IndexModel();
                ideas.Ideas = dbContext.Ideas.Include(e => e.Creator).Include(e => e.Likes).ThenInclude(u => u.User).ToList();
                return View("Home", ideas);
            }
        }

        [Route("delete/{ideaid}")]
        public IActionResult Delete(string ideaid)
        {
            int ideaId = Convert.ToInt32(ideaid);
            Idea idea = dbContext.Ideas.FirstOrDefault(i => i.IdeaId == ideaId);
            dbContext.Remove(idea);
            dbContext.SaveChanges();
            return RedirectToAction("home");
        }

        [Route("users/{userid}")]
        public IActionResult Userpage(string userid)
        {
            int userId = Convert.ToInt32(userid);
            User user = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            ViewBag.Posts = dbContext.Ideas.Where(i => i.UserId == userId).Count();

            List<Like> likes = dbContext.Likes.Where(i => i.UserId == userId).ToList();
            ViewBag.Likes = likes.Count();

            return View("user", user);
        }

        [Route("idea/{ideaId}")]
        public IActionResult IdeaPage(string ideaid)
        {
            int ideaId = Convert.ToInt32(ideaid);
            Idea idea = dbContext.Ideas.FirstOrDefault(i => i.IdeaId == ideaId);
            User user = dbContext.Users.FirstOrDefault(u => u.UserId == idea.UserId);
            ViewBag.Creator = user.Alias;
            ViewBag.idea = idea.Content;
            List<Like> likes = dbContext.Likes.Where(i => i.IdeaId == ideaId).Include(i => i.User).ToList();

            return View("idea", likes);
        }

        [Route("like/{ideaid}")]
        public IActionResult Like(string ideaid)
        {
            int ideaId = Convert.ToInt32(ideaid);
            User current = dbContext.Users.FirstOrDefault(u => u.UserId == int.Parse(HttpContext.Session.GetString("ID")));
            Like newLike = new Like(current.UserId,ideaId);
            dbContext.Add(newLike);
            dbContext.SaveChanges();

            return RedirectToAction("home");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("index");
        }
    }
}

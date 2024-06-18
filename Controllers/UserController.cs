using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;



namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();

        public object String { get; private set; }

        // GET: User
        public ActionResult Index()
        {
            return View(userlist);
        }


        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }


        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            userlist.Add(user);
            return RedirectToAction("Index");
        }


        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
             

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            var userToUpdate = userlist.FirstOrDefault(u => u.Id == id);
            if (userToUpdate == null)
            {
                return HttpNotFound();
            }
            userlist.Remove(userToUpdate);
            userlist.Add(user); // In a real application, you'd update properties individually
            return RedirectToAction("Index");
        }


        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }


        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                userlist.Remove(user);
            }
            return RedirectToAction("Index");
        }

    }
}

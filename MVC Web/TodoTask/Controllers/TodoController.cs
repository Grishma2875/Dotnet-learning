using Microsoft.AspNetCore.Mvc;
using TodoApp.Data;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoDbContext _context;

        public TodoController(TodoDbContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            var todos = _context.Todos
                .Where(x => !x.IsDeleted)
                .ToList();

            return View(todos);
        }

        // CREATE - Form Open
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // CREATE - Save Data
        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                todo.IsDeleted = false;

                _context.Todos.Add(todo);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(todo);
        }

        // EDIT - Form Open
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var todo = _context.Todos
                .FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        // EDIT - Update Data
        [HttpPost]
        public IActionResult Edit(Todo todo)
        {
            if (ModelState.IsValid)
            {
                var existingTodo = _context.Todos
                    .FirstOrDefault(x => x.Id == todo.Id && !x.IsDeleted);

                if (existingTodo == null)
                {
                    return NotFound();
                }

                existingTodo.TaskName = todo.TaskName;
                existingTodo.UserName = todo.UserName;
                existingTodo.Description = todo.Description;

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(todo);
        }

        // SOFT DELETE
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var todo = _context.Todos
                .FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (todo == null)
            {
                return NotFound();
            }

            todo.IsDeleted = true;

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
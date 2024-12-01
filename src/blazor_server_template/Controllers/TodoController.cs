using Microsoft.AspNetCore.Mvc;

namespace Blazor_Server_Template.Controllers
{
    /// <summary>
    /// API for managing To-Do items.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private static readonly List<TodoItem> Todos = new();

        /// <summary>
        /// Gets all To-Do items.
        /// </summary>
        /// <returns>List of To-Do items.</returns>
        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok(Todos);
        }

        /// <summary>
        /// Gets a specific To-Do item by ID.
        /// </summary>
        /// <param name="id">The ID of the To-Do item.</param>
        /// <returns>The requested To-Do item.</returns>
        [HttpGet("{id}")]
        public IActionResult GetTodoById(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return NotFound();

            return Ok(todo);
        }

        /// <summary>
        /// Creates a new To-Do item.
        /// </summary>
        /// <param name="todo">The To-Do item to create.</param>
        /// <returns>The created To-Do item.</returns>
        [HttpPost]
        public IActionResult CreateTodo([FromBody] TodoItem todo)
        {
            todo.Id = Todos.Count > 0 ? Todos.Max(t => t.Id) + 1 : 1;
            Todos.Add(todo);
            return CreatedAtAction(nameof(GetTodoById), new { id = todo.Id }, todo);
        }

        /// <summary>
        /// Updates an existing To-Do item.
        /// </summary>
        /// <param name="id">The ID of the To-Do item to update.</param>
        /// <param name="updatedTodo">The updated To-Do item.</param>
        /// <returns>No content on success.</returns>
        [HttpPut("{id}")]
        public IActionResult UpdateTodo(int id, [FromBody] TodoItem updatedTodo)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return NotFound();

            todo.Title = updatedTodo.Title;
            todo.IsCompleted = updatedTodo.IsCompleted;

            return NoContent();
        }

        /// <summary>
        /// Deletes a To-Do item by ID.
        /// </summary>
        /// <param name="id">The ID of the To-Do item to delete.</param>
        /// <returns>No content on success.</returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteTodo(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return NotFound();

            Todos.Remove(todo);
            return NoContent();
        }

        /// <summary>
        /// Represents a To-Do item.
        /// </summary>
        public class TodoItem
        {
            /// <summary>
            /// The ID of the To-Do item.
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// The title of the To-Do item.
            /// </summary>
            public string Title { get; set; } = string.Empty;

            /// <summary>
            /// Whether the To-Do item is completed.
            /// </summary>
            public bool IsCompleted { get; set; }
        }
    }
}

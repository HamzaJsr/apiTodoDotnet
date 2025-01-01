using System;

namespace TodoApi
{
    public class TodoServices
    {
        private readonly List<Todo> _list =
        [
            new(1, "Finir video sur C#", DateTime.Now, new DateTime(2024,12,31)),
            new(2, "Commencer cours OCR sur C#", DateTime.Now, new DateTime(2025,01,31))
        ];

        public List<Todo> GetAll() => _list;

        public Todo? GetTodoById(int id) => _list.Find(todo => todo.id == id);
    

        public Todo AddTodo(Todo todo) 
        {
            int id = _list.Count > 0 ? _list.Max(t => t.id) + 1 : 1;
            Todo newTodo = new(id, todo.title, DateTime.Now, todo.endDate);
            _list.Add(newTodo);
            return newTodo;
        }

        public Todo UpdateTodo(Todo updatedTodo, int id)
        {
           DeleteTodo(id);

            Todo newUpdatedDoto = new(id, updatedTodo.title, DateTime.Now, updatedTodo.endDate);
             _list.Add(newUpdatedDoto);
             return newUpdatedDoto;
            
        }

        public Todo DeleteTodo(int id)
        {
              Todo todo = GetTodoById(id);
            _list.Remove(todo);
            return todo;
        }

    }

  
}

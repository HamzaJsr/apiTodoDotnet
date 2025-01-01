
using Microsoft.AspNetCore.Mvc;
using TodoApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TodoServices>();

var app = builder.Build();


app.MapGet("/todos", (TodoServices service) =>
{
 List<Todo> result = service.GetAll();
    return Results.Ok(result);
});

app.MapGet("/todo/{id:int}", (int id, TodoServices service) =>
{
    Todo todo = service.GetTodoById(id);
    if (todo is not null)
    {
        return Results.Ok(todo);
    }

    return Results.NotFound();

});

app.MapGet("/todos/actives", () =>
{

});

app.MapPost("/todo", (
    [FromBody] Todo todo, 
    TodoServices service) =>
{
    return Results.Ok(service.AddTodo(todo));
});

app.MapDelete("/todo/{id:int}", (int id, TodoServices service) =>
{
     Todo result = service.DeleteTodo(id);

    return Results.Ok($"La tâche '{result.title}' a bien etait supprimé.");

});

app.MapPut("/todo/{id:int}", (int id, [FromBody] Todo updatedTodo, TodoServices service) =>
{
    Todo result = service.UpdateTodo(updatedTodo, id);

    return Results.Ok(result);
});

app.Run();



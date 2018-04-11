using ListViewCompleteGuide.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace ListViewCompleteGuide.ViewModels
{
    public class TodoViewModel : ReactiveObject
    {
        ReactiveList<Todo> _todos;
        public ReactiveList<Todo> Todos
        {
            get => _todos;
            set => this.RaiseAndSetIfChanged(ref _todos, value);
        }
        private Todo _selectedTodo;
        public Todo SelectedTodo
        {
            get => _selectedTodo;
            set => this.RaiseAndSetIfChanged(ref _selectedTodo, value);
        }

        public ReactiveCommand DeleteTodoCommand { get; private set; }

        public TodoViewModel()
        {
            Todos = new ReactiveList<Todo>() { ChangeTrackingEnabled = true };

            Todos.Add(new Todo { IsDone = false, Title = "Go to Sleep" });
            Todos.Add(new Todo { IsDone = false, Title = "Go get some dinner" });
            Todos.Add(new Todo { IsDone = false, Title = "Watch GOT" });
            Todos.Add(new Todo { IsDone = true, Title = "Code code and code!!!!" });

            ///Lets detect when ever a todo Item is marked as done 
            ///IF it is, it is sent to the bottom of the list
            ///Else nothing happens
            Todos.ItemChanged.Where(x => x.PropertyName == "IsDone" && x.Sender.IsDone)
                .Select(x => x.Sender)
                .Subscribe(x =>
                {
                    if (x.IsDone)
                    {
                        Todos.Remove(x);
                        Todos.Add(x);
                    }
                });

           DeleteTodoCommand = ReactiveCommand.Create<Todo>(t =>
           {
               Todos.Remove(t);
           });
        }
    }
}

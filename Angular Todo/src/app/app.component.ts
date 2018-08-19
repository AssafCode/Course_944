import { Component } from '@angular/core';
import { TodosService } from './todos/todos.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  appTodos: string[];

  constructor(private todosService: TodosService){
    this.appTodos = this.todosService.getTodos();
  }

  onTodoAdd(todo: string) {
    if (todo)
      this.appTodos.push(todo);
  }

  onDeleteTodo(index: number){
    this.appTodos.splice(index, 1);
  }
}

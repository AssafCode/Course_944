import { NgModule } from "../../../node_modules/@angular/core";
import { TodoFormComponent } from "./todo-form/todo-form.component";
import { TodosListComponent } from "./todos-list/todos-list.component";
import { TodoItemComponent } from "./todo-item/todo-item.component";
import { CommonModule } from "../../../node_modules/@angular/common";
import { TodosService } from "./todos.service";


@NgModule({
    declarations:[
        TodoFormComponent,
        TodosListComponent,
        TodoItemComponent
    ],
    imports:[
        CommonModule
    ],
    exports:[
        TodoFormComponent,
        TodosListComponent
    ],
    providers: [
        TodosService
    ]
})
export class TodosModule{}
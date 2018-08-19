import { Component, Input, Output, EventEmitter } from "@angular/core";
import { TodosService } from "../todos.service";

@Component({
    selector: 'todo-item',
    templateUrl: 'todo-item.component.html'
})
export class TodoItemComponent{
    @Input()
    todo: string;

    @Input()
    index: number;

    @Output()
    remove = new EventEmitter<number>();

    onClick(){
        this.remove.emit(this.index);
    }
}

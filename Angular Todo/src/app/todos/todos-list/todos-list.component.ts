import { Component, Input, Output, EventEmitter } from "@angular/core";

@Component({
    selector: 'todos-list',
    templateUrl: './todos-list.component.html'

})
export class TodosListComponent{
    @Input()
    todos: string[];

    @Output()
    remove = new EventEmitter<number>();

    onRemove(index: number){
        this.remove.emit(index);
    }
}
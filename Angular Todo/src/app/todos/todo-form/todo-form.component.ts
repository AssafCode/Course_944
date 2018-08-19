import { Component, Output, EventEmitter } from "@angular/core";


@Component({
    selector: 'todo-form',
    templateUrl: './todo-form.component.html'
})
export class TodoFormComponent{
    
    @Output()
    submit: EventEmitter<string> = new EventEmitter<string>();

    onSubmit(inputElement: HTMLInputElement){
        this.submit.emit(inputElement.value);
        inputElement.value = "";
    }
}

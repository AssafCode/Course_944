import { CounterService } from "./counter.service";
import { Component } from "../../../node_modules/@angular/core";

@Component({
    selector: 'app-counter-single',
    template: `
        <div>
            {{counterService.count}}
        </div>
        <div>
            <button (click)="counterService.inc()">+</button>
            <button (click)="counterService.dec()">-</button>
        </div>
    `
})
export class CounterSingleComponent{
    constructor(private counterService: CounterService){}
}
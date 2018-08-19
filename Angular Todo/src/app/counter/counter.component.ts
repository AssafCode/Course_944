import { Component } from "../../../node_modules/@angular/core";
import { CounterService } from "./counter.service";

@Component({
    selector: 'app-counter',
    providers:[CounterService],
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
export class CounterComponent{
    constructor(private counterService: CounterService){}
}

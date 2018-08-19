import { $ } from "../../../node_modules/protractor";

export class CounterService{
    count = 0;

    inc(){
        this.count += 1;
    }

    dec(){
        this.count -= 1;
    }
}

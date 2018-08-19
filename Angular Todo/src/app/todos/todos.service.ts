import { AppService } from "../app.service";
import { Injectable } from "../../../node_modules/@angular/core";

@Injectable()
export class TodosService{

    constructor(private appService: AppService){

    }

    getTodos(): string[]{
        return ["angular 1", "react"];
    }
}


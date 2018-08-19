import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TodosModule } from './todos/todos.module';
import { AppService } from './app.service';
import { CounterComponent } from './counter/counter.component';
import { CounterService } from './counter/counter.service';
import { CounterSingleComponent } from './counter/counter-single.component';

@NgModule({
  declarations: [
    AppComponent,
    CounterComponent,
    CounterSingleComponent
  ],
  imports: [
    BrowserModule,
    TodosModule
  ],
  providers: [
    AppService,
    CounterService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
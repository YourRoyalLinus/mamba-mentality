import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FetchService} from './fetch.service'

import { AppComponent } from './app.component';
import { QuoteService } from './quote.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [FetchService, QuoteService],
  bootstrap: [AppComponent]
})
export class AppModule { }

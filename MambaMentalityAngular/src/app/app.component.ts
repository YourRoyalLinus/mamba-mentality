import { Component } from '@angular/core';
import { QuoteService } from './quote.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'MambaMentalityAngular';
  public get quoteBox() : string { return this.quote.quoteBox}
  public get quotePov() : string { return this.quote.quotePov} 
  public get error() : boolean { return this.quote.error} 
  
constructor(private quote: QuoteService) {}

  ngOnInit(){
    this.GenerateNewQuote()
  }

  GenerateNewQuote(){
    this.quote.NewQuote()
  }
}

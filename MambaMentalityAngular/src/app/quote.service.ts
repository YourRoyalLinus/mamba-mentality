import { Injectable } from '@angular/core';
import { FetchService } from './fetch.service';

@Injectable({
  providedIn: 'root'
})

export class QuoteService {
  quoteId = Math.floor(Math.random() * 31) //make sure this is shared across sessions?
  cache = [];
  quoteBox = '';
  quotePov = '';
  error = false;

  constructor(private fetch: FetchService) { }
 
  NewQuote(){
    while(this.cache.includes(this.quoteId))
      this.quoteId = Math.floor(Math.random() * 31)
    
    this.cache.push(this.quoteId)
    this.RefreshCache()
    this.DisplayQuote(this.quoteId)

    return;
  }

  DisplayQuote(quoteId){
    this.fetch.fetchQuote(quoteId).subscribe(data => {
      if(data){ 
        this.error = false;
        //set quote for QuoteBox
        this.quoteBox = data.quoteText
        //set pov for QuoteBox
        this.quotePov = data.poV
        //Display button to update
      }}, () =>{
        this.error = true
        this.quoteBox = 'There was an error generating a quote! Please try again momentarily.'
        this.quotePov = "Administrator"
   })
  }

  private RefreshCache(){
    while(this.cache.length >= 10)
      this.cache.shift()
    return;
  }
}

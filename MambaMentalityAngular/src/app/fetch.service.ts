import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface Quote {
  id: number,
  quoteText: string,
  poV: string
}

@Injectable({
  providedIn: 'root'
})

export class FetchService {

  constructor(private http: HttpClient) { }

  fetchQuote(value){
    let url = '/api/quote' + '/' + value;
    return this.http.get<Quote>(url)
  }
}

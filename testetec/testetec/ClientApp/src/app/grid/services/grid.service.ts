import { Injectable } from '@angular/core';
import { BaseService } from 'src/services/base.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GridService extends BaseService {

  constructor (
      public http: HttpClient
  ) {
      super('Rick','');
  }

  public get(): Observable<any[]>{
    return this.http.get<any[]>(this.apiEndpoint)
  }
}

import { Injectable } from '@angular/core';
import { PathSharedService } from '../../path-shared.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FilesMusulman } from '../../Models/NvMusulman/files-musulman.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FilesmusulmanService {


  constructor(private pathService: PathSharedService,
    private http: HttpClient) { }

  readonly rootURL = this.pathService.getPath();
  formData: FilesMusulman;
  headers = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Accept': 'application/json'
    })
  }

  PutObservableE(Transaction: FilesMusulman) {
    return this.http.put<FilesMusulman>(this.rootURL + '/filesmusulmen/' + Transaction.id, Transaction, this.headers);

  }
  //Create Cadeaux

  Create(tache: FilesMusulman) {
    return this.http.post<FilesMusulman>(this.rootURL + '/filesmusulmen', tache, this.headers);
  }

  //Edit Cadeaux
  Edit() {
    return this.http.put(this.rootURL + '/filesmusulmen/' + this.formData.id, this.formData, this.headers);
  }

  // List Cadeaux

  List(): Observable<FilesMusulman[]> {
    return this.http.get<FilesMusulman[]>(this.rootURL + '/filesmusulmen');
  }

  //Delete Cadeaux

  Delete(id) {
    return this.http.delete(this.rootURL + '/filesmusulmen/' + id);
  }

  //Put Cadeaux


  Put(Id) {
    return this.http.put(this.rootURL + '/filesmusulmen/' + this.formData.id, this.formData, this.headers);
  }

  //Get Cadeaux By Id

  GetById(Id) {
    return this.http.get<FilesMusulman>(this.rootURL + '/filesmusulmen/' + Id);
  }
}

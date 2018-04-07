import { Component, OnInit } from '@angular/core';
import { User } from '../../models/user';
import { UserRepository } from '../../repositories/user.repository';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  users: User[];
  dataSorted: boolean = false;

  constructor(private userRepository: UserRepository) { }

  ngOnInit() {
    this.users = this.userRepository.getUsers();
  }

  onSearch(query: string){
    let searchQuery = query.toLowerCase();
    let result = this.userRepository.getSearchResult(searchQuery);

    if(result != null)
      this.users = result;
    else
      this.users = [];
  }

  onFilterByCategory(category) {
    this.users = this.userRepository.getFilterByCategoryResult(category);
  }

  onSort(key) { 
    if(!this.dataSorted){
      this.users.sort(function(a, b) {
        var x = a[key];
        var y = b[key];
        return ((x < y) ? -1 : ((x > y) ? 1 : 0));
      })
      this.dataSorted = true;
    }
    else {
      this.users.sort(function(a, b) {
        var x = a[key];
        var y = b[key];
        return ((x < y) ? 1 : ((x > y) ? -1 : 0));
      })
      this.dataSorted = false;
    }
  }
}

import { Injectable } from '@angular/core';
import { User } from '../models/user';
import { UserService } from '../services/user.service';

@Injectable()
export class UserRepository {
    private users: User[] = [];

    constructor(private userSerivce: UserService) {
        userSerivce.getUsers().subscribe(data => this.users = data)
    }

    getUsers() {
        return this.users;
    }

    getSearchResult(searchQuery: string){
        return this.users.filter(user => user.name.toLowerCase().includes(searchQuery));
    }

    getFilterByCategoryResult(category: string){
        if(category == "Все")
            return this.users;
        else
            return this.users.filter(user => user.role == category);
    }

}
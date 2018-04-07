import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import { User } from '../models/user';

const Users = [ 
    new User(1, 'Первый', 'Пароль', 'Менеджер'),
    new User(2, 'Второй', 'Пароль', 'Менеджер'),
    new User(3, 'Третий', 'Пароль', 'Раб'),
    new User(4, 'Четвертый', 'Пароль', 'Менеджер'),
    new User(5, 'Пятый', 'Пароль', 'Раб'),
]

@Injectable()
export class UserService {
    private API_PATH = 'пока его нет';

    constructor(private http: HttpClient){}

    getUsers(): Observable<User[]> {
        return Observable.of(Users);
    }
}
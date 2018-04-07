import { Component, OnInit, Input, Output, EventEmitter, OnDestroy } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Component({
  selector: 'app-data-table',
  templateUrl: './data-table.component.html',
  styleUrls: ['./data-table.component.css']
})
export class DataTableComponent implements OnInit, OnDestroy {

  _dataSource = new BehaviorSubject<any>([]);
  _dataKeys: any[];

  @Output() sortKey = new EventEmitter<string>();

  @Input() 
    set dataSource(value) {
        this._dataSource.next(value);
    }

    get data() {
      return this._dataSource.getValue();
    }

  sortColumn(key){
    this.sortKey.emit(key);
  }

  constructor() { }

  ngOnInit() {
    this._dataSource.subscribe(data => this._dataKeys = Object.keys(data[0]))
  }

  ngOnDestroy() {
    this._dataSource.unsubscribe();
  }

}

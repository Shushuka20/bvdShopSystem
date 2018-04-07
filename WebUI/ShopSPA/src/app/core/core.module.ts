import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DataTableComponent } from './components/data-table/data-table.component';
import { DataSearchComponent } from './components/data-search/data-search.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    FormsModule
  ],
  declarations: [DataTableComponent, DataSearchComponent],
  exports: [DataTableComponent, DataSearchComponent]
})
export class CoreModule { }

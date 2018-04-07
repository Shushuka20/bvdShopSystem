import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { SubHeaderComponent } from './components/sub-header/sub-header.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [HeaderComponent, SidebarComponent, SubHeaderComponent],
  exports: [HeaderComponent, SidebarComponent, SubHeaderComponent]
})
export class LayoutModule { }

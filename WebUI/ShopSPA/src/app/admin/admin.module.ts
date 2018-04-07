import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../core/core.module';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { UsersComponent } from './containers/users/users.component';
import { routes } from './routes';
import { UserService } from './services/user.service';
import { UserRepository } from './repositories/user.repository';
import { LayoutModule } from '../layout/layout.module';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    CoreModule,
    HttpClientModule,
    LayoutModule
  ],
  declarations: [UsersComponent],
  providers: [UserService, UserRepository]
})
export class AdminModule { }

import { Routes } from '@angular/router';

export const routes:Routes = [
    { path: '', redirectTo: '/admin', pathMatch: 'full' },
    { path: 'admin', loadChildren: './admin/admin.module#AdminModule' }
]
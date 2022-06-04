import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {
  ChatComponent, HomeComponent, BackupComponent
} from 'src/pages';

const routes : Routes = [
  { path: "",       redirectTo: "home", pathMatch: "full" },
  { path: "home",   component: HomeComponent              },
  { path: "chat",   component: ChatComponent              },
  { path: "backup", component: BackupComponent            }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

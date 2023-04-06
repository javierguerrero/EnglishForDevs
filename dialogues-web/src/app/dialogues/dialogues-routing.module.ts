import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { CategoryComponent } from './pages/category/category.component';
import { TopicComponent } from './pages/topic/topic.component';
import { ListComponent } from './pages/list/list.component';
import { DialogueComponent } from './pages/dialogue/dialogue.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    children: [
      {
        path: 'list',
        component: ListComponent,
      },
      {
        path: 'category/:id',
        component: CategoryComponent,
      },
      {
        path: 'topic/:id',
        component: TopicComponent,
      },
      {
        path: 'dialogue/:id',
        component: DialogueComponent,
      },
      {
        path: '**',
        redirectTo: 'list',
      },
    ],
  },
  {
    path: '**',
    redirectTo: '404',
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DialoguesRoutingModule {}

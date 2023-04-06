import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './pages/home/home.component';
import { CategoryComponent } from './pages/category/category.component';
import { TopicComponent } from './pages/topic/topic.component';
import { DialoguesRoutingModule } from './dialogues-routing.module';
import { MaterialModule } from '../material/material.module';
import { DialogueComponent } from './pages/dialogue/dialogue.component';
import { ListComponent } from './pages/list/list.component';

@NgModule({
  declarations: [
    HomeComponent,
    CategoryComponent,
    TopicComponent,
    DialogueComponent,
    ListComponent,
  ],
  imports: [CommonModule, DialoguesRoutingModule, MaterialModule],
})
export class DialoguesModule {}

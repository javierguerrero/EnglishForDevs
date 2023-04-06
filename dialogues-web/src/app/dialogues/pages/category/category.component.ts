import { Component } from '@angular/core';
import { Category } from '../../interfaces/category.interface';
import { DialogueService } from '../../services/dialogue.service';
import { Topic } from '../../interfaces/topic.interface';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css'],
})
export class CategoryComponent {
  topics: Topic[] = [];

  constructor(private dialogueService: DialogueService) {}

  ngOnInit() {
    this.dialogueService.getTopics().subscribe((topics) => {
      this.topics = topics;
    });
  }
}

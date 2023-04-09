import { Component } from '@angular/core';
import { DialogueService } from '../../services/dialogue.service';
import { Topic } from '../../interfaces/topic.interface';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css'],
})
export class CategoryComponent {
  topics: Topic[] = [];

  constructor(
    private activatedRoute: ActivatedRoute,
    private dialogueService: DialogueService
  ) {}

  ngOnInit() {
    this.activatedRoute.params
      .pipe(switchMap(({ id }) => this.dialogueService.getTopics(id)))
      .subscribe((topics) => (this.topics = topics));
  }
}

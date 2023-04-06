import { Component } from '@angular/core';
import { Category } from '../../interfaces/category.interface';
import { DialogueService } from '../../services/dialogue.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css'],
})
export class ListComponent {
  categories: Category[] = [];

  constructor(private dialogueService: DialogueService) {}

  ngOnInit() {
    this.dialogueService.getCategories().subscribe((categories) => {
      this.categories = categories;
    });
  }
}

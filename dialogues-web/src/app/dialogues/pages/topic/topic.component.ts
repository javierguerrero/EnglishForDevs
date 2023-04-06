import { Component } from '@angular/core';
import { Dialogue } from '../../interfaces/dialogue.interface';

@Component({
  selector: 'app-topic',
  templateUrl: './topic.component.html',
  styleUrls: ['./topic.component.css'],
})
export class TopicComponent {
  levels = [
    { id: 1, name: 'A1' },
    { id: 2, name: 'A2' },
    { id: 3, name: 'B1' },
    { id: 4, name: 'B2' },
    { id: 5, name: 'C1' },
    { id: 6, name: 'C2' },
  ];

  dialogue!: Dialogue;

  generate() {
    this.dialogue = {
      turns: [
        {
          order: 1,
          speaker: 'Person 1',
          message: 'Hello',
          translation: {
            language: 'es',
            message: 'Hola',
          },
        },
        {
          order: 2,
          speaker: 'Person 2',
          message: 'How are you?',
          translation: {
            language: 'es',
            message: '¿Cómo estás?',
          },
        },
        {
          order: 3,
          speaker: 'Person 1',
          message: "I'm fine, thanks.",
          translation: {
            language: 'es',
            message: 'Estoy bien, gracias',
          },
        },
      ],
    };
  }
}

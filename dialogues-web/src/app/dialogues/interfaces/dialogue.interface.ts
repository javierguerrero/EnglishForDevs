export interface Dialogue {
  id?: number;
  turns: Turn[];
}

export interface Turn {
  order: number;
  speaker: string;
  message: string;
  translation: Tranlation;
}

export interface Tranlation {
  language: string;
  message: string;
}

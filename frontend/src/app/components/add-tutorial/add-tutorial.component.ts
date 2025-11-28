import { Component } from '@angular/core';
import { TutorialService } from 'src/app/services/tutorial.service';

@Component({
  selector: 'app-add-tutorial',
  templateUrl: './add-tutorial.component.html',
  styleUrls: ['./add-tutorial.component.css']
})
export class AddTutorialComponent {

  tutorial = {
    title: '',
    description: '',
    published: false
  };

  constructor(private tutorialService: TutorialService) {}

  saveTutorial(): void {
    const data = {
      title: this.tutorial.title,
      description: this.tutorial.description
    };

    this.tutorialService.create(data)
      .subscribe(response => {
        console.log("Saved successfully:", response);
        alert("Tutorial Added Successfully!");
        this.tutorial = { title: '', description: '', published: false };
      });
  }
}

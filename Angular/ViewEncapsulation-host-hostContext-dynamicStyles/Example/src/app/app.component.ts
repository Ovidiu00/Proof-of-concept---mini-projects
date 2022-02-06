import { Component } from '@angular/core';
import { ListType } from './components/Enums/ListType.enum';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  public verticalViewEnum: ListType = ListType.VerticalView;
  public horizontalViewEnum: ListType = ListType.HorizontalView;
}

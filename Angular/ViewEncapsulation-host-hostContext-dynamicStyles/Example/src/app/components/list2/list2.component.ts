import { Component, Input } from '@angular/core';
import { ListType } from '../Enums/ListType.enum';

@Component({
  selector: 'app-list2',
  templateUrl: './list2.component.html',
  styleUrls: ['./list2.component.css'],
})
export class List2Component {
  @Input()
  public view!: ListType;

  public isVerticalView(): boolean {
    return this.view == ListType.VerticalView;
  }
  public isHorizontalView(): boolean {
    return this.view == ListType.HorizontalView;
  }

  public getListViewTypeClass() {
    return {
      vertical: this.isVerticalView(),
      horizontal: this.isHorizontalView(),
    };
  }
}

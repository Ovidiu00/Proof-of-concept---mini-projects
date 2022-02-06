import { Component, Input, OnInit } from '@angular/core';
import { ListType } from '../Enums/ListType.enum';

@Component({
  selector: 'app-list-item2',
  templateUrl: './list-item2.component.html',
  styleUrls: ['./list-item2.component.css']
})
export class ListItem2Component implements OnInit {

  constructor() { }

  @Input()
  public view!: ListType;

  public isVerticalView(): boolean {
    return this.view == ListType.VerticalView;
  }
  public isHorizontalView(): boolean {
    return this.view == ListType.HorizontalView;
  }

  ngOnInit(): void {
  }

}

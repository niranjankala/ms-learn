import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateBookComponent } from './update-book.component';

describe('UpdateBookComponent', () => {
  let component: UpdateBookComponent;
  let fixture: ComponentFixture<UpdateBookComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateBookComponent]
    });
    fixture = TestBed.createComponent(UpdateBookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

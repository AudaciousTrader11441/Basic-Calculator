// calculator.component.ts
import { Component } from '@angular/core';
import { CalculatorService } from '../service/Calculator/calculator.service';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
 

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  number1: number = 0;
  number2: number = 0;
  result: number | null = null;
  closeResult: string = '';

  constructor(private modalService: NgbModal,private calculatorService: CalculatorService) {}

  performAddition() {
    this.calculatorService.add(this.number1, this.number2)
      .subscribe(result => {
        this.result = result;
      });
  }

  performSubtraction() {
    this.calculatorService.subtract(this.number1, this.number2)
      .subscribe(result => {
        this.result = result;
      });
  }
  open(content:any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  } 
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }

}

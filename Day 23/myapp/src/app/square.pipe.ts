import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'square'
})
export class SquarePipe implements PipeTransform {

  transform(num1: number): number {
    let result = num1 * num1;
    return result;
  }

}

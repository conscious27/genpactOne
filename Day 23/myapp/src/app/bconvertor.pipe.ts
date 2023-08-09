import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'bconvertor'
})
export class BconvertorPipe implements PipeTransform {

  transform(tbyte : number, btype:string='KB'): string {
    let result = (tbyte/1024).toFixed(2)+btype;
    return result;
  }

}

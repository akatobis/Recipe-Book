import { Injectable } from '@angular/core';

@Injectable({
  providedIn:'root'
})
export class PreloaderService {
  private static smallLoadingCount: boolean = false;

  getPreloaderCount(): any {
    return PreloaderService.smallLoadingCount;
  }

  showPreloader(): void {
    PreloaderService.smallLoadingCount = true;
  }

  hidePreloader(): void {
    PreloaderService.smallLoadingCount = false;
  }
}

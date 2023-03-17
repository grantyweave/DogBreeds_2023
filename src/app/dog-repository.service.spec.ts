import { TestBed } from '@angular/core/testing';

import { DogRepositoryService } from './dog-repository.service';

describe('DogRepositoryService', () => {
  let service: DogRepositoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DogRepositoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

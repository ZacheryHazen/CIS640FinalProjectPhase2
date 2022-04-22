/*
* Licensed under the MIT License, see LICENSE file for details.
*/

const shouldHideBuilding = require('../../Portal/Areas/Maps/wwwroot/js/maps');

describe('maps.js', () => {
   describe('shouldHideBuilding', () => {
      test('should hide buildings with no content', () => {
         expect(shouldHideBuilding("Anderson", "", "")).toBe(true);
         expect(shouldHideBuilding("Engg", "", "")).toBe(true);
      });
      
      test('should not take input capitalization into account', () => {
         expect(shouldHideBuilding("anderson", "Anderson Hall", "A")).toBe(false);
         expect(shouldHideBuilding("engg", "Engineering Complex", "Engg")).toBe(false);
         expect(shouldHideBuilding("Anderson", "anderson hall", "a")).toBe(false);
         expect(shouldHideBuilding("Engg", "engineering complex", "engg")).toBe(false);
      });
      
      test('should show Anderson Hall when search is for "And"', () => {
         expect(shouldHideBuilding("And", "Anderson Hall", "A")).toBe(false);
      });
      
      test('should hide Anderson Hall when search is for "Engg"', () => {
         expect(shouldHideBuilding("Engg", "Anderson Hall", "A")).toBe(true);
      });
      
      test('should show Engineering Complex when search is for "Engg"', () => {
         expect(shouldHideBuilding("Engg", "Engineering Complex", "Engg")).toBe(false);
      });
      
      test('should hide Engineering Complex when search is for "And"', () => {
         expect(shouldHideBuilding("And", "Engineering Complex", "Engg")).toBe(true);
      });
   });
});

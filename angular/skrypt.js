var FizzBuzzApp = angular.module('FizzBuzzApp', []);
 
FizzBuzzApp.controller('ListaWynikow', function ($scope) {
  $scope.przyklad = [
    1,2, 'Fizz', 4, 'Buzz', 'Fizz', 7, 8, 'Fizz'
  ];
  $scope.wyniki = function(){
    return $scope.przyklad.slice(0, $scope.liczby);
  };
});
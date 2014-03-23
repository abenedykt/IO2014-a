var fizzBuzzApp = angular.module('fizzBuzzApp', []);

fizzBuzzApp.controller('FBListCtrl', function ($scope) {
    $scope.numbers = [1, 2, "Fizz", 4, "Buzz", 6, 7, 8, "Fizz", "Buzz"];

    $scope.ZwrocWyniki = function (index) {
        return $scope.numbers.slice(0, index);
    };
});
var fizzBuzzApp = angular.module('fizzBuzzApp', []);
var url = 'api/FizzBuzz/';

fizzBuzzApp.factory('fizzBuzzFactory', function ($http) {
    return {
        getFb: function (index) {
            return $http.get(url+index);
        }
    };
});
fizzBuzzApp.controller('FBListCtrl', function ($scope,$http) {
    $scope.ZwrocWyniki = function (index) {

        return $http.get(url+index);
    };
});
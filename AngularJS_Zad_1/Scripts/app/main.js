var fizzBuzzController = angular.module('fizzBuzzApp', []);

fizzBuzzController.factory('dataFactory', ['$http', function ($http) {

        var urlBase = 'api/FizzBuzz/';
        var dataFactory = {};

        dataFactory.getFb = function (id) {
            return $http.get(urlBase + id);
        };

        return dataFactory;
    }]);

fizzBuzzController.controller('FBListCtrl', ['$scope', 'dataFactory',
        function ($scope, dataFactory) {
            $scope.zapytka = function(index) {
                dataFactory.getFb(index).success(function(data) {
                    $scope.numbers = data;
                });
            };


        }]);

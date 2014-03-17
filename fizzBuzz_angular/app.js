  var myApp = angular.module('FizzBuzz', []);

  myApp.controller('FizzBuzzController', ['$scope', function($scope){
      $scope.podanaWartosc = 0;
      $scope.spice = 'very';
      $scipe.items = [
        {'value':'aaaadaw'},
        {'value':'awdawdawf'},
        {'value':'awdffwafaw'}
        ];
      
      $scipe.items2 = [];

      $scope.spicy = function(podanaWartosc){
          $scope.items2 = $scope.items.slice(0,$scope.podanaWartosc);
      };
  }]);
function mainController($scope, $http) {
    $scope.input = 1;
    $scope.output = [];

    $scope.get = function () {
        var input = $scope.input;
        if (input) {
            $http.get("/api/fizzbuzz?count=" + input).success(function (data) {
                $scope.output = data;
            });
        }
    };
}

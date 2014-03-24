function BindModel($scope, $http)
{
	$scope.input = 1;

    $scope.dane = [];

	$scope.output = function (index)
	{
	    $http({
	        url: "/api/FizzWeb/" + $scope.input,
	        method: "GET"
	    }).success(function(data, status, headers, config) {
	        $scope.dane = data;
	    });


	};
}
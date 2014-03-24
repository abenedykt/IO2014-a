function BindModel($scope)
{
	var fizzBuzz = ["1", "2", "Fizz", "4", "Buzz", "6", "7", "8"];
	$scope.input = 1;

	$scope.output = function(index)
	{
		return fizzBuzz.slice(0, index);
	};
}
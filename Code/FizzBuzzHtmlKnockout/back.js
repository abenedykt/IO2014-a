var initialValue = ["1","2","Fizz","4","Buzz","Fizz","7","8"];

var ViewModel = function()
{
	var self = this;

	self.number = ko.observable(1);
	self.array = initialValue;    		
};

ko.applyBindings(new ViewModel());
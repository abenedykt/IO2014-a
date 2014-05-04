function AppViewModel() {
    var self = this;

    self.input = ko.observable(0);
    self.result = ko.observableArray();

    self.change = function () {
          if (self.input()) {
        $.get("/api/fizzbuzz?count=" + self.input(), function (data) {
            self.result(data);
        });
         }
    };
};

ko.applyBindings(new AppViewModel());
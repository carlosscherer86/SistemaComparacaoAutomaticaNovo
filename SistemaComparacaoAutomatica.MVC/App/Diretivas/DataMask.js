angular.module("SistemaComparacaoAutomatica").directive("nascDir", function ($filter) {
    return {
        require: "ngModel",
        link: function (scope, element, attrs, ctrl) {
            var _formatDate = function (date) {
                date = date.replace(/[^0-9]+/g, "");
                if (date.length > 2) {
                    date = date.substring(0, 2) + "/" + date.substring(2);
                }
                if (date.length > 5) {
                    date = date.substring(0, 5) + "/" + date.substring(5, 9);
                }
                return date;
            };

            element.bind("keyup", function () {
                ctrl.$setViewValue(_formatDate(ctrl.$viewValue));
                ctrl.$render();
            });

            element.bind("blur", function () {
                isValidDate(ctrl.$viewValue);
            });

            ctrl.$parsers.push(function (value) {
                if (value.length === 10) {
                    var dateArray = value.split("/");
                    return new Date(dateArray[2], dateArray[1] - 1, dateArray[0]).getTime();
                }
            });

            ctrl.$formatters.push(function (value) {
                return $filter("date")(value, "dd/MM/yyyy");
            });

            function isValidDate(dateStr) {
                // Checks for the following valid date formats: 
                // MM/DD/YYYY 
                // Also separates date into month, day, and year variables 
                var datePat = /^(\d{2,2})(\/)(\d{2,2})\2(\d{4}|\d{4})$/;
                var matchArray = dateStr.match(datePat); // is the format ok? 
                if (matchArray == null) {
                    alert("Date must be in MM/DD/YYYY format")
                    return false;
                }
            }
        }
    };
});
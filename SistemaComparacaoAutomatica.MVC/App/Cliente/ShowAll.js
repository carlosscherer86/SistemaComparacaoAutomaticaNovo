angular.module("SistemaComparacaoAutomatica").controller("ClienteShowAllController", function ($scope, $http) {
    $scope.title = 'Clientes';
    $scope.clientes = [];
    var getClientes = function () {
        $http.get("/Cliente/IndexAngular").success(function (data) {
            $scope.clientes = data;
        });
    }

    getClientes();
});
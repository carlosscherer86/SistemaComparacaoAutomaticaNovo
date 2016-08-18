angular.module("SistemaComparacaoAutomatica").controller("ClienteCreateController", function ($scope, $http) {
    $scope.title = 'Cadastro de Clientes';
    $scope.UFs = [];
    $scope.showMessage = true;

    var setCliente = function () {

    }

    var getUF = function () {
        $http.get("/Cliente/CarregarUF").success(function (data) {
            $scope.UFs = data;
        });
    }

    getUF();
});
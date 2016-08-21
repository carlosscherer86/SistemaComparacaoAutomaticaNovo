angular.module("SistemaComparacaoAutomatica").controller("ClienteCreateController", function ($scope, $http) {
    $scope.title = 'Cadastro de Clientes';
    $scope.UFs = [];
    $scope.showMessage = false;
    $scope.message = '';
    $scope.setCliente = function (cliente) {
        if (cliente.Senha.localeCompare(cliente.ConfirmacaoSenha) != 0) {
            $scope.showMessage = true
            $scope.message = 'Senhas diferentes!';
            return;
        }

        $http.post("/Cliente/Create", cliente).success(function (data) {
            window.location = "/Login/Login";
        });
    }

    var getUF = function () {
        $http.get("/Cliente/CarregarUF").success(function (data) {
            $scope.UFs = data;
        });
    }

    getUF();
});
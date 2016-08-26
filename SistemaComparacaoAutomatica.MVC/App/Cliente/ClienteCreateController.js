angular.module("SistemaComparacaoAutomatica").controller("ClienteCreateController", function ($scope, ClienteService) {
    $scope.title = 'Cadastro de Clientes';
    $scope.UFs = [];
    $scope.showMessage = false;
    $scope.message = '';
    $scope.emailValido = true;
    $scope.setCliente = function (cliente) {
        if (cliente.Senha.localeCompare(cliente.ConfirmacaoSenha) != 0) {
            $scope.showMessage = true
            $scope.message = 'Senhas diferentes!';
            return;
        }

        ClienteService.setCliente(cliente).success(function (data) {
            window.location = "/Login/Login";
        });
    }

    $scope.validaEmail = function (email) {
        ClienteService.validaEmail(email).success(function(data)
        {
            if(data.localeCompare("true")==0)
            {
                $scope.emailValido = true;
            } else {
                $scope.emailValido = false;
                $scope.showMessage = true
                $scope.message = 'Email inválido!';
            }
        })
    }

    var getUF = function () {
        ClienteService.getUF().success(function (data) {
            $scope.UFs = data;
        });
    }

    getUF();
});
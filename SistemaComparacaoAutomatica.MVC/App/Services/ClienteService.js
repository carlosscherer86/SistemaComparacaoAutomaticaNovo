angular.module("SistemaComparacaoAutomatica").service("ClienteService", function($http) {
    this.getUF = function () {
        return $http.get("/Cliente/CarregarUF");
    }

    this.setCliente = function (cliente) {
        return $http.post("/Cliente/Create", cliente);
    }

    this.validaEmail = function (email) {
        return $http.post("/Cliente/ValidaEmail", email);
    }
})
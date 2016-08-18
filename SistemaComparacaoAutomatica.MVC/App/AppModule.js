var app = angular.module("SistemaComparacaoAutomatica", ["ngRoute"]);

app.factory("ShareData", function () {
    return { idCliente: 0 }
});


app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/ShowClientes',
                        {
                            templateUrl: 'Cliente/ShowClientes',
                            controller: 'ClienteIndexController'
                        });

    $routeProvider.otherwise(
                        {
                            redirectTo: '/'
                        });

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
}]);
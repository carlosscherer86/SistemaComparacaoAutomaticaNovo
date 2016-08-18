angular.module("SistemaComparacaoAutomatica").directive("cepDir", CepDir);


function CepDir() {
    return {
        link: function (scope, element, attrs) {
            var options = {
                onKeyPress: function (val, e, field, options) {
                    putMask();
                }
            }

            $(element).mask('00000-000', options);

            function putMask() {
                var mask;
                var cleanVal = element[0].value.replace(/\D/g, '');//pega o valor sem mascara
                mask = "00000-000";
                $(element).mask(mask, options);//aplica a mascara novamente
            }
        }
    }
}
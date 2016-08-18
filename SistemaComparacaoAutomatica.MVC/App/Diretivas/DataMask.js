angular.module("SistemaComparacaoAutomatica").directive("dateDir", DateDir);

function DateDir() {
    return {
        link: function (scope, element, attrs) {
            var options = {
                onKeyPress: function (val, e, field, options) {
                    putMask();
                }
            }

            $(element).mask('00/00/0000', options);

            function putMask() {
                var mask;
                var cleanVal = element[0].value.replace(/\D/g, '');//pega o valor sem mascara
                mask = "00/00/0000";
                $(element).mask(mask, options);//aplica a mascara novamente
            }
        }
    }
}
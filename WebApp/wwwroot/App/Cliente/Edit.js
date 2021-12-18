"use strict";
var ClienteEdit;
(function (ClienteEdit) {
    var Entity = $("#AppEdit").data('entity');
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity
        },
        methods: {
            Save: function () {
                if (BValidateData(this.Formulario)) {
                    Loading.fire("Guardando");
                    App.AxiosProvider.ClienteGuardar(this.Entity).then(function (data) {
                        Loading.close();
                        if (data.CodeError == 0) {
                            Toast.fire({ title: "Registro almacenado.", icon: "success" }).then(function () { return window.location.href = "Cliente/Grid"; });
                        }
                        else {
                            Toast.fire({ title: data.MsgError, icon: "error" });
                        }
                    });
                }
                else {
                    Toast.fire({ title: "Campos obligatorios." });
                }
            }
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(ClienteEdit || (ClienteEdit = {}));
//# sourceMappingURL=Edit.js.map
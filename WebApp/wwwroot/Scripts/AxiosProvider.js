"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        //WBL Code
        //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
        //export const CompraEliminar = (id) => axios.delete<DBEntity>("Compra/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
        //export const CompraGuardar = (entity) => axios.post<DBEntity>("Compra/Edit", entity).then(({ data }) => data);
        //export const ProductoEliminar = (id) => axios.delete<DBEntity>("Producto/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
        //export const ProductoGuardar = (entity) => axios.post<DBEntity>("Producto/Edit", entity).then(({ data }) => data);
        //export const ClienteEliminar = (id) => axios.delete<DBEntity>("Cliente/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
        //export const ClienteGuardar = (entity) => axios.post<DBEntity>("Cliente/Edit", entity).then(({ data }) => data);
        //API Code
        //Cliente
        AxiosProvider.ClienteEliminar = function (id) { return ServiceApi.delete("api/Cliente/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteGuardar = function (entity) { return ServiceApi.post("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteActualizar = function (entity) { return ServiceApi.put("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        //Producto
        AxiosProvider.ProductoEliminar = function (id) { return ServiceApi.delete("api/Producto/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoGuardar = function (entity) { return ServiceApi.post("api/Producto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoActualizar = function (entity) { return ServiceApi.put("api/Producto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        //Compra
        AxiosProvider.CompraEliminar = function (id) { return ServiceApi.delete("api/Compra/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraGuardar = function (entity) { return ServiceApi.post("api/Compra", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraActualizar = function (entity) { return ServiceApi.put("api/Compra", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map
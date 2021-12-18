
namespace App.AxiosProvider   {

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
    export const ClienteEliminar = (id) => ServiceApi.delete<DBEntity>("api/Cliente/" + id).then(({ data }) => data);
    export const ClienteGuardar = (entity) => ServiceApi.post<DBEntity>("api/Cliente", entity).then(({ data }) => data);
    export const ClienteActualizar = (entity) => ServiceApi.put<DBEntity>("api/Cliente", entity).then(({ data }) => data);

    //Producto
    export const ProductoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Producto/" + id).then(({ data }) => data);
    export const ProductoGuardar = (entity) => ServiceApi.post<DBEntity>("api/Producto", entity).then(({ data }) => data);
    export const ProductoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Producto", entity).then(({ data }) => data);

    //Compra
    export const CompraEliminar = (id) => ServiceApi.delete<DBEntity>("api/Compra/" + id).then(({ data }) => data);
    export const CompraGuardar = (entity) => ServiceApi.post<DBEntity>("api/Compra", entity).then(({ data }) => data);
    export const CompraActualizar = (entity) => ServiceApi.put<DBEntity>("api/Compra", entity).then(({ data }) => data);


}





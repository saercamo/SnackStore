# SnackStore

_Proyecto de evaluacion de Applaudo Studio_

## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de  pruebas._

Mira **Deployment** para conocer como desplegar el proyecto.


### Pre-requisitos 📋

_Software requerido_

```
IIS 8
Postman
```

### Instalación 🔧

_A continuacion las instrucciones de instalacion_

_Descompresion de archivo SnackStore.rar en directorio C:\inetpub\wwwroot\SnackStore_

_Publicacion en IIS del sitio SnackStore, utilizando protocolo https (utilizar certificado por defecto)_

_Una vez finalizado, se puede acceder a los servicios mediante la URL https://localhost:443/v1/[Nombre_servicio]_

## Ejecutando las pruebas ⚙️

_Ingresar a Postman y en la URL colocar la ruta https://localhost:443/v1/[NombreServicio]_
```
Servicio AddProducts (Consumir como metodo POST https://localhost:443/v1/AddProduct):
{
	"product_id":1
	,"product_name":"Nachos"
	,"product_description":"Deliciosos Nachos"
	,"creation_date": "2019-07-19"
	, "quantity_stock": 100
	, "price_product": 2
}
,
{
	"product_id":2
	,"product_name":"Churro"
	,"product_description":"Delicioso churro"
	,"creation_date": "2019-07-19"
	, "quantity_stock": 150
	, "price_product": 1
}
,
{
	"product_id":3
	,"product_name":"Refresco"
	,"product_description":"Deliciosa bebida"
	,"creation_date": "2019-07-19"
	, "quantity_stock": 0
	, "price_product": 0.5
}

Servicio GetProducts (Consumir como servicio Get https://localhost:443/v1/GetProducts)
La salida es similar a lo siguiente:
{
    "1": {
        "product_id": 1,
        "product_name": "Nachos",
        "product_description": "Deliciosos Nachos",
        "creation_date": "2019-07-19T00:00:00",
        "quantity_stock": 100,
        "price_product": 2
    },
    "2": {
        "product_id": 2,
        "product_name": "Churro",
        "product_description": "Delicioso churro",
        "creation_date": "2019-07-19T00:00:00",
        "quantity_stock": 150,
        "price_product": 1
    },
    "3": {
        "product_id": 3,
        "product_name": "Refresco",
        "product_description": "Deliciosa bebida",
        "creation_date": "2019-07-19T00:00:00",
        "quantity_stock": 0,
        "price_product": 0.5
    }
}

Servicio GetAvailableProducts (Consumir como servicio Get https://localhost:443/v1/GetAvailableProducts)
{
    "1": {
        "product_id": 1,
        "product_name": "Nachos",
        "product_description": "Deliciosos Nachos",
        "creation_date": "2019-07-19T00:00:00",
        "quantity_stock": 100,
        "price_product": 2
    },
    "2": {
        "product_id": 2,
        "product_name": "Churro",
        "product_description": "Delicioso churro",
        "creation_date": "2019-07-19T00:00:00",
        "quantity_stock": 150,
        "price_product": 1
    }
}

Servicio DeleteProduct (Consumir como servicio DELETE https://localhost:44353/v1/DeleteProduct?product_id=[product_id])
Sustituir el valor de product_id por el id del producto a eliminar.

Servicio UpdateStock (Consumir como servicio POST https://localhost:44353/v1/UpdateStock?product_id=[product_id]&quantity=[cantidad])
Donde product_id es el identificador de producto y quantity la cantidad de stock a registrar para el producto.

Servicio UpdatePrice (Consumir como servicio POST https://localhost:44353/v1/UpdatePrice?product_id=[product_id]&price=[precio])
Donde product_id es el id de producto y precio es el precio asociado.

Servicio GetPriceLog (Consumir como servicio POST https://localhost:44353/v1/GetPriceLog?product_id=[product_id])
Donde product_id corresponde al producto al cual se le desea consultar el historial de cambio de precios.

```

## Construido con 🛠️

_Se utilizaron las siguientes herramientas:_

* [Visual Studio 2019](https://visualstudio.microsoft.com/es/vs/) - IDE
* [Framework NetCore 2.1](https://dotnet.microsoft.com/download/dotnet-core/2.1) -Framework utilizado

## Autores ✒️

* **Salvador Cabrera** - *Trabajo Inicial* - [saercamo](https://github.com/saercamo/)

También puedes mirar la lista de todos los [contribuyentes](https://github.com/your/project/contributors) quíenes han participado en este proyecto. 



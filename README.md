![](https://user-images.githubusercontent.com/6364350/227820028-916b3bf1-29b1-406d-8b80-99d27df2b262.png)

[![](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE.txt)
[![GitHub commit activity](https://img.shields.io/github/commit-activity/m/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://github.com/sergiokml/)
[![GitHub contributors](https://img.shields.io/github/contributors/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://github.com/sergiokml/LibreDteDotNet.SoapRequest/graphs/contributors/)

[![Nuget](https://img.shields.io/nuget/v/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://www.nuget.org/packages/LibreDteDotNet.SoapRequest/)
[![Nuget](https://img.shields.io/nuget/dt/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://www.nuget.org/stats/packages/LibreDteDotNet.SoapRequest?groupby=Version)
[![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://github.com/sergiokml/LibreDteDotNet.SoapRequest)
[![Lines of code](https://img.shields.io/tokei/lines/github/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://github.com/sergiokml/LibreDteDotNet.SoapRequest)

# LibreDteDotNet.SoapRequest
This solution tries to show how to access the information published by the [Servicio de Impuestos Internos](https://www.sii.cl/) through SOAP (WCF) services. The services are packaged in "Library Class" and can be accessed through Dependency Injection.

>This repository has no relationship with the government entity [SII](https://www.sii.cl/), only for educational purposes.

##
### ✅ Details
| Reference | version |
|:--| :--:
| .Net Core | 6.0 |
| Autofac | 7.0.0 |
| Autofac.Extensions.DependencyInjection | 8.0.0 |
| Microsoft.Extensions.Hosting.Abstractions | 7.0.0 |
| Security.Cryptography.Xml | 7.0.1 |
| System.ServiceModel.Duplex | 4.10.* |
| System.ServiceModel.Http | 4.10.* |
| System.ServiceModel.NetTcp | 4.10.* |

### 🛠️ RoadMap
- [x] "Solicitar y Firmar Token Access" [Autenticación Automática](https://www.sii.cl/factura_electronica/factura_mercado/autenticacion.pdf)
- [x] "Consulta de Estado DTE" [Consulta de Estado DTE](https://www.sii.cl/factura_electronica/factura_mercado/estado_dte.pdf)
- [x] "Consulta Avanzada Estado de DTE" [Consulta Avanzada Estado de DTE](https://www.sii.cl/factura_electronica/factura_mercado/OIFE2006_QueryEstDteAv_MDE.pdf)
- [x] "Consulta de Estado de Upload DTE
" [Consulta de Estado de Upload Dte
](https://www.sii.cl/factura_electronica/factura_mercado/estado_envio.pdf)
- [ ] "Web Service de Consulta y Registro de
Aceptación/Reclamo a DTE recibido" [Web Service de Consulta y Registro de
Aceptación/Reclamo a DTE recibido](https://www.sii.cl/factura_electronica/Webservice_Registro_Reclamo_DTE_V1.1.pdf)


### 🚀 Usage
This class is accessed via dependency injection:
```C#
IHost host = Host.CreateDefaultBuilder()
  .SoapRequestBuild() // This is important!
  .ConfigureServices(
    (c, s) => {
      // your config
    }
  )
  .Build();
```
#### 📖 [**TokenSeed.GetToken()**](#%EF%B8%8F-roadmap)
```C#
var tkn = await soapRequest.TokenSeed.GetToken("16000555-2");
```
#### 📖 [**EstadoDte.GetEstado()**](#%EF%B8%8F-roadmap)
###### Retorna el ```estado de la aceptación``` de un DTE enviado al SII.
![image](https://user-images.githubusercontent.com/6364350/228645107-d3d05d31-a99b-49a1-ba62-45fcf024f7a9.png)
```C#
XDocument estado = await soapRequest.EstadoDte.GetEstado(
  "77522012", // empresa emisor
  "0",
  "76888555",  // empresa receptora
  "4",
  TipoDoc.FacturaExentaElectronica, // 33 - 34 - 61
  "6",    // folio
  "27032023",  // fecha
  "931487",   // monto
  tkn    // token
);
```
#### 📖 [**EstadoDte.GetEstado()**](#%EF%B8%8F-roadmap)
###### Retorna el ```estado de la aceptación``` mediante la entrega del Tag ```DTE/Signature/SignatureValue``` desde un DTE ya enviado al SII.
![image](https://user-images.githubusercontent.com/6364350/228648331-215c5572-52fb-4513-a501-6630140294e1.png)
```C#
XDocument estadoAv = await soapRequest.EstadoDte.GetEstado(
  "77522000", // empresa emisor
  "0",
  "76888555",  // empresa receptora
  "4",
  TipoDoc.FacturaExentaElectronica,
  "402268",    // folio
  "15032023",  // fecha
  "1407781",   // monto
  "VLVLlBYc3eQ2NtkRxdANRYBQKW9pbG7Y1feuDG/1WZlpAyB43gTIxMYvs9yIrwCy5Z5piK51IF6u\r\nyugfFghOs+97yfjd+pNGzxKG6wpstz2YGAoz+nO4npymFwRT0jueYHWMivHtcQjF+ZddWsGNU6v8\r\nb0AvZPvFqhsAzGRxOfwV3YrmPrqYOBvTvzGWAr+AyB1jYXcSzN/sx31qp3riUbx2KjdE8UeZ2r5Z\r\nuP0BYMEXUt+Eh40ftm95nLPjQppM626xWPdH9FPr6WBBgTCup/HGlefDsxPeZJA2HPeRwuKn78WH\r\niu/Arvf27OQH5MuFWX1ns1fOLHSt6nIhoNIbhQ==",
  tkn
);
```
#### 📖 [**EstadoDte.GetEstadoUp()**](#%EF%B8%8F-roadmap)
###### Retorna el ```estado del upload``` de un DTE enviado al SII, se debe contar con el Track ID del envío.
![image](https://user-images.githubusercontent.com/6364350/229174554-3e4942d9-df9a-41e4-b0e1-6951e110f5d6.png)
```C#
ResEstadoDteUp.RESPUESTA validar = await soapRequest.EstadoDte.GetEstadoUp(
    "77522000",     // rut company
    "1",
    "NGHHHHHHHHHHH",  // ID Track
    tkn           // token
);

```
####
---
### 📫 Have a question? Found a Bug? 
Feel free to **file a new issue** with a respective title and description on the [LibreDteDotNet.SoapRequest/issues](https://github.com/sergiokml/LibreDteDotNet.SoapRequest/issues) repository.
### ❤️ Community and Contributions
I think that **Knowledge Doesn’t Belong to Just Any One Person**, and I always intend to share my knowledge with other developers, a voluntary monetary contribution or contribute ideas and/or comments to improve these tools would be appreciated.

 [![PayPal](https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white)](https://www.paypal.com/donate/?hosted_button_id=PTKX9BNY96SNJ)
### 📘 License
All my repository content is released under the terms of the [MIT License](LICENSE.txt).

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
### ✅&nbsp; Details
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

### 🛠️&nbsp; RoadMap
- [x] Add Feature: "Solicitar y Firmar Token Access" [Autenticación Automática](https://www.sii.cl/factura_electronica/factura_mercado/autenticacion.pdf)
- [ ] Add Feature: "Consulta de Estado DTE" [Consulta de Estado DTE](https://www.sii.cl/factura_electronica/factura_mercado/estado_dte.pdf)
- [ ] Add Feature: "Consulta Avanzada Estado de DTE" [Consulta Avanzada Estado de DTE](https://www.sii.cl/factura_electronica/factura_mercado/OIFE2006_QueryEstDteAv_MDE.pdf)
- [ ] Add Feature: "Consulta de Estado de Upload DTE
" [Consulta de Estado de Upload Dte
](https://www.sii.cl/factura_electronica/factura_mercado/estado_envio.pdf)
- [ ] Add Feature: "Web Service de Consulta y Registro de
Aceptación/Reclamo a DTE recibido" [Web Service de Consulta y Registro de
Aceptación/Reclamo a DTE recibido](https://www.sii.cl/factura_electronica/Webservice_Registro_Reclamo_DTE_V1.1.pdf)


### 🚀&nbsp; Usage
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
---
#### 📖 [**TokenSeed.GetToken()**](#%EF%B8%8F-roadmap)
![image](https://user-images.githubusercontent.com/6364350/228638249-434bc817-9d9c-4cb7-ae90-ed16587b220a.png)
```C#
var tkn = await soapRequest.TokenSeed.GetToken("16000555-2");
```
#### 📖 [**EstadoDte.GetEstado()**](#%EF%B8%8F-roadmap)
![image](https://user-images.githubusercontent.com/6364350/228636499-cc71c16e-6416-429a-b8bb-b1a53cd29660.png)
```C#
XDocument estado = await soapRequest.EstadoDte.GetEstado(
  "77522012", // empresa emisor
  "0",
  "76888555",  // empresa receptora
  "4",
  "33",  // tipo doc
  "6",    // folio
  "27032023",  // fecha
  "931487",   // monto
  tkn    // token
);
```
####
---
### 📫&nbsp; Have a question? Found a Bug? 
Feel free to **file a new issue** with a respective title and description on the [LibreDteDotNet.SoapRequest/issues](https://github.com/sergiokml/LibreDteDotNet.SoapRequest/issues) repository.
### ❤️&nbsp; Community and Contributions
I think that **Knowledge Doesn’t Belong to Just Any One Person**, and I always intend to share my knowledge with other developers, a voluntary monetary contribution or contribute ideas and/or comments to improve these tools would be appreciated.

 [![PayPal](https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white)](https://www.paypal.com/donate/?hosted_button_id=PTKX9BNY96SNJ)
### 📘&nbsp; License
All my repository content is released under the terms of the [MIT License](LICENSE.txt).

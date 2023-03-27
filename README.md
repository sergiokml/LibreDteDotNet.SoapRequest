![](https://user-images.githubusercontent.com/6364350/227820028-916b3bf1-29b1-406d-8b80-99d27df2b262.png)

[![](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE.txt)
[![GitHub commit activity](https://img.shields.io/github/commit-activity/y/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://github.com/sergiokml/)
[![GitHub contributors](https://img.shields.io/github/contributors/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://github.com/sergiokml/)


[![Nuget](https://img.shields.io/nuget/v/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://www.nuget.org/packages/LibreDteDotNet.SoapRequest/)
[![Nuget](https://img.shields.io/nuget/dt/LibreDteDotNet.SoapRequest?style=for-the-badge)](https://www.nuget.org/packages/LibreDteDotNet.SoapRequest/)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)
![GitHub repo file count](https://img.shields.io/github/directory-file-count/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)


[![GitHub tag (latest by date)](https://img.shields.io/github/v/tag/sergiokml/LibreDteDotNet.SoapRequest?style=for-the-badge)](../../releases/latest)
[![GitHub all releases](https://img.shields.io/github/downloads/sergiokml/LibreDteDotNet.SoapRequest/total?style=for-the-badge)](../../releases)

This solution tries to show how to access the information published by the [Servicio de Impuestos Internos](https://www.sii.cl/) through SOAP services. The services are packaged in "Library Class" and can be accessed through Dependency Injection.

It should be noted that this repository has no relationship with the government entity, only for educational purposes.


### 📝&nbsp; Details
||
|:--|
| Framework .Net 6.0 |
| Autofac 7.0.0 |
| Autofac.Extensions.DependencyInjection 8.0.0 |
| Security.Cryptography.Xml 7.0.1 |

### ✅&nbsp; Requirements

+ Framework .Net >= 5.0.
+ Autofac Framework.

### 🛠️&nbsp; RoadMap

- [x] Add Feature: "Solicitar y Firmar Token Access" [Autenticación Automática](https://www.sii.cl/factura_electronica/factura_mercado/autenticacion.pdf)
- [ ] Add Feature: "Consulta de Estado DTE" [Consulta de Estado DTE](https://www.sii.cl/factura_electronica/factura_mercado/autenticacion.pdf)
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
Function : GetToken
```C#
var tkn = await soapRequest.TokenSeedService.GetToken("16000555-2");
```
---
### 📫&nbsp; Have a question? Found a Bug? 

Feel free to **file a new issue** with a respective title and description on the [LibreDteDotNet.SoapRequest/issues](https://github.com/sergiokml/LibreDteDotNet.SoapRequest/issues) repository.

### ❤️&nbsp; Community and Contributions

I think that **Knowledge Doesn’t Belong to Just Any One Person**, and I always intend to share my knowledge with other developers, a voluntary monetary contribution or contribute ideas and/or comments to improve these tools would be appreciated.

 [![PayPal](https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white)](https://www.paypal.com/donate/?hosted_button_id=PTKX9BNY96SNJ)


### 📘&nbsp; License

All my repository content is released under the terms of the [MIT License](LICENSE.txt).

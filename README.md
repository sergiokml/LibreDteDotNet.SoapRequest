<br />
<p align="center">
  <a href="" target="_blank">
    <img width="20%" src="https://www.sii.cl/sobre_el_sii/logoSII250x108.jpg" alt="Azure Function">
  </a>
</p>
<br />
<p align="center">
  <a href="LICENSE.txt" target="_blank">
    <img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="">
  </a>
  <a href="https://github.com/sergiokml/FunctionPdfConvert/releases" target="_blank">
    <img src="https://img.shields.io/github/tag/sergiokml/FunctionPdfConvert.svg" alt="">
  </a>
  <a href="https://github.com/sergiokml/" target="_blank">
    <img src="https://img.shields.io/github/commit-activity/y/sergiokml/FunctionPdfConvert.svg" alt="">
  </a>
  <a href="https://github.com/sergiokml/FunctionPdfConvert/contributors" target="_blank">
    <img src="https://img.shields.io/github/contributors-anon/sergiokml/FunctionPdfConvert.svg" alt="">
  </a>
  <a href="https://github.com/sergiokml/FunctionPdfConvert/releases" target="_blank">
    <img alt="GitHub all releases" src="https://img.shields.io/github/downloads/sergiokml/FunctionPdfConvert/total">
  </a> 
</p>
<br />

This solution tries to show how to access the information published by the [Servicio de Impuestos Internos](https://www.sii.cl/) through SOAP / REST services. The services are packaged in "Library Class" and can be accessed through Dependency Injection.


### 📝&nbsp; Details

<table>
  <thead>
  </thead>
  <tbody>
    <tr>   
      <td style="text-align: left;">Framework .Net 6.0</td>      
    </tr>
    <tr>    
      <td style="text-align: left;">Security.Cryptography.Xml 7.0.1</td>      
    </tr>      
  </tbody>
</table>


### ✅&nbsp; Requirements

+ Framework .Net >= 5.0.

### 🛠 RoadMap

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


 
 his function can be hosted on a server and called from a POST request, upload the file and wait for the result. The file is uploaded to the Sharepoint site (linked to OneDrive) and when downloaded, the [Graph](https://learn.microsoft.com/en-us/graph/overview) tool automatically converts it into a PDF document. 

These are the [supported](https://learn.microsoft.com/en-us/graph/api/driveitem-get-content-format?view=graph-rest-1.0&tabs=http#format-options) files:

<table>
  <thead>
    <tr>
      <th style="text-align: left;">Format value</th>
      <th style="text-align: left;">Description</th>
      <th>Supported source extensions</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td style="text-align: left;">pdf</td>
      <td style="text-align: left;">Converts the item into PDF format.</td>
      <td>csv, doc, docx, odp, ods, odt, pot, potm, potx, pps, ppsx, ppsxm, ppt, pptm, pptx, rtf, xls, xlsx</td>
    </tr>
  </tbody>
</table>

### 📫&nbsp; Have a question? Found a Bug? 

Feel free to **file a new issue** with a respective title and description on the [FunctionPdfConvert/issues](https://github.com/sergiokml/FunctionPdfConvert/issues) repository.

### ❤️&nbsp; Community and Contributions

I think that **Knowledge Doesn’t Belong to Just Any One Person**, and I always intend to share my knowledge with other developers, a voluntary monetary contribution or contribute ideas and/or comments to improve these tools would be appreciated.

<p align="center">
    <a href="https://www.paypal.com/donate/?hosted_button_id=PTKX9BNY96SNJ" target="_blank">
        <img width="15%" src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white" alt="Azure Function">
    </a>
</p>


### 📘&nbsp; License

All my repository content is released under the terms of the [MIT License](LICENSE.txt).

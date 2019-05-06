# Vortx

Para executar a validação do projeto extraia os dados do pacote recebido via e-mail no disco local c:\Pacote\ ...

Folders:
- API: Contém os system file do webAPI
- WebSite: Contém o app de front-end am angular 7
- Collection-Postman: Import no postman e efetue os testes da api

# back-end

  - WEB API .NET Core 2.2
  - Principios solid
  - Conceitos do DDD
  - Automapper
  - FluentValidator
  - Domain Notification Pattern
  - MVC
  - Clean Code
  - Server Kestrel


Para executar a apllicação efetue os passos abaixo:
  - Acesse a pasta API dentro de do arquivo de pacote de deploy que você recebeu c:\Pacotes\API\ ...
  - Abra o PowerSehell neste diretorio e execute o seguinte comando:    dotnet vortx.api.dll
  - Acesse o seguinte endereço no seu browser http://localhost:5000/api/v1/plan,
 Você deve receber o seguinte retorno caso a aplicação execute com sucesso [{"areaCode":11,"region":"São Paulo - Jundiaí - Itu - Bragança Paulista"},{"areaCode":16,"region":"Ribeirão Preto - Franca - São Carlos - Araraquara"},{"areaCode":17,"region":"São José do Rio Preto - Catanduva - Barretos - Votuporanga"},{"areaCode":18,"region":"Presidente Prudente - Araçatuba - Birigui - Assis"}]

Teste via postman:
 - [GET] http://localhost:5000/api/v1/plan : Obtém as regiões e seus respectivos codigos.
 
 - [GET] http://localhost:5000/api/v1/plan/{Codigo_do_plano}/{DDD_Origin}/{DDD_destiny}/{Minutes_Connection}: Obtém o valor a ser cobrado neste ligação
 - [POST] http://localhost:5000/api/v1/plan : Mesma ação do end_point acima porém é necessario enviar o objeto abaixo via post {
	"plancode" :30,
	"origin": 11,
	"destiny": 16,
	"starttime" : "5/5/2019 4:00:36",
	"endtime" : "5/5/2019 4:31:36"
}


# Front-End

Para validar a funcionalidade desta aplicação efetue o passo abaixo:

- Acesse este diretorio C:\Pacotes\WebSite\ClientApp dentro do arquivo de pacote de deploy recebido via e-mail.
- Abra o PowerShell e execute o seguinte comando: ng server

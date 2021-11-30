<!-- LOGO DO PROJETO -->
<br />
<div align="center">
  <img src="https://user-images.githubusercontent.com/82387795/144043679-41b44f92-b743-4f56-9df7-4a8650a40ccd.png" alt="Logo" width="300" height="300">

  <h3 align="center">Desafio Roman</h3>

  <p align="center">
    A plataforma de auxílio aos professores!
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template"><strong>Explore o projeto »</strong></a>
    <br />
    <br />
    <a href="https://github.com/chibobinho">Yuri Chiba</a>
    ·
    <a href="https://github.com/luizfelipeveracruz">Luiz Felipe</a>
    ·
    <a href="https://github.com/fe-lino">Felipe Lino</a>
  </p>
</div>


<!-- SOBRE O PROJETO -->
## Sobre o projeto
<p align="justify">Os professores de uma escola de tecnologia, ao longo do tempo, criam diversas situações-problema com escopos de projetos propostos aos alunos, porém isto se dá de forma individualizada, com pouco compartilhamento e uniformidade entre os colegas de equipe.</p>
<p align="justify">Portanto, Roman é um sistema de propostas de projetos que serão compartilhados entre os professores. Este é o desenvolvimento de uma plataforma para sugestão de projetos, onde a interface com o usuário é uma <strong>aplicação mobile</strong>.</p>

## Documentação sobre o ambiente

* [React Native](https://reactjs.org/)
* [ASP.NET Web API](https://dotnet.microsoft.com/apps/aspnet/apis)

## Configurando sua máquina

1. Clone o repositório do projeto
   ```sh
   git clone https://github.com/luizfelipeveracruz/Desafio-Roman
   ```

2. Execute os scripts do banco de dados [BD](https://github.com/luizfelipeveracruz/Desafio-Roman/tree/main/BancoDeDados/scripts)
   
3. Altere a linha 31 da [RomanContext.cs](https://github.com/luizfelipeveracruz/Desafio-Roman/blob/main/Back-End/senai_roman_webAPI/senai_roman_webAPI/Contexts/RomanContext.cs) com as informações do banco de dados gerado anteriormente
   ```cs
   optionsBuilder.UseSqlServer("Data Source=Nome do servidor; initial catalog=Nome do catálogo; user Id=Logon de autenticação; pwd=Senha de autenticação;");
   ```
   
4. Altere a linha 22 da [launchSettings.json](https://github.com/luizfelipeveracruz/Desafio-Roman/blob/main/Back-End/senai_roman_webAPI/senai_roman_webAPI/Properties/launchSettings.json) com seu o seu IP
   ```json
   "applicationUrl": "http://seu-endereço-ip:5000",
   ```

5. Abra o CMD e execute a API
   ```cmd
   cd Back-end\desafio_roman_webApi\desafio_roman_webApi
   dotnet run
   ```
   
6. Instale os pacotes NPM da [Mobile](https://github.com/luizfelipeveracruz/Desafio-Roman/tree/main/Mobile)
   ```sh
   npm install
   ```
   
7. Execute a interface [Mobile](https://github.com/luizfelipeveracruz/Desafio-Roman/tree/main/Mobile)
   ```sh
   npm react-native run-android
   ```
    
    

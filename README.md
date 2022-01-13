<h1> WebAgenda </h1>

<p>Projeto desenvolvido em C# ultilizando Asp.Net Core 3.1</p>
<h3>Dependências</h3>
<ul>
  <li>Entity Framework Core 3.1.22</li>
  <li>Entity Framework Core Tools 3.1.22<</li>
  <li>Entity Framework Core SQLServer 3.1.22</li>
  <li>Entity Framework Core Design 3.1.22</li>
</ul>

<h3>Solução</h3>
<p>A solução foi desenvolvida aplicando o conceito de Solid, desenvolvimento em camadas, separando a camada de negócio de dados e da aplicação.</p>

<h3>Banco de Dados</h3>
<p>O banco de dados utilizado, foi o SQLServer 13.0.4</p>
<p>Existe um arquivo chamado DatabaseQuery.txt com a estrura do banco de das tabelas.</p>
<p>Para a configuração do SQLServer, caso não utilize o SQLServer Local do Visual Studio, é necessário alterar as configurações do arquivo appsettings.json.</p>
<p>Caso altere o nome da chave DefaultConnection no arquivo appsettings.json, será necessário também o atualizar no arquivo Startup.cs</p>
<p>Caso prefira, é possível criar o banco diretamente pelo projeto através das Migrations, apenas será necessário alterar a solução para a biblioteca WebAgenda.Data.</p>

<h3>Build</h3>
<p>Para o Build é necessário instalar as dependências e adicionar as bibliotecas.</p>
<p>Também é necessário importar o Banco de Dados ou realizar uma migração nova.</p>




# Salão do Pantcho
### Sistema Web - Salão do Pantcho
###### Versão 1.0

###### Descrição:
<p>Projeto Web de um Salão Barbershop chamado Salão do Pantcho.</p>
<p>O Sistema consiste na Interação e Gerenciamento de todas as funcionalidades providas pelo sistema por parte dos seus Clientes e Administradores.</p>

###### Detalhes Técnicos:
- Projeto: ASP NET
- Linguagem: C#
- Tecnologias Back-End: MVC5 + ORM Entity Framework - E.F (Fluent API)  + Ninject + AutoMapper;
- Tecnologias Front-End: HTML5 + CSS3 + JQquery + BootStrap;
- Base de Dados: SQLServer (.mdf);
- Arquitetura do Projeto: a arquitetura do projeto atualmente está criada em DDD - Domain Driven Design contendo dez camadas descritas abaixo: <br />
**SalaoDoPantcho.Web:** camada responsável pela apresentação contendo a arquitetura de padrão de responsabilidade chamada MVC; <br />
**SalaoDoPantcho.App:**
**CatalogoLivros.Util:** camada baseada no conceito Cross-Cutting Concerns* e responsável pelas Operações Utilitárias e Secundárias do Sistema; <br />
**CatalogoLivros.Domain:** camada responsável por todas as entidades de negócio, regras e suas características; <br />
**CatalogoLivros.Interfaces:** camada responsável por todas as Assinaturas dos Métodos (Funcionalidades) que são implementados na camada CatalogoLivros.DAL; <br />
**CatalogoLivros.DAL:** camada responsável pela manipulação de dados; **CatalogoLivros.SGBDDAL:** camada responsável pela fonte de acesso dos dados).

<p>Cross-Cutting Concerns*: São funcionalidades que não estão diretamente relacionadas ao domínio da aplicação ou às suas respectivas regras de negócio, mas que ainda sim, são importantes para o Software. Exemplos: envio de emails, criptografia de senhas, etc.</p>

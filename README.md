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
**SalaoDoPantcho.Web:** Camada de Apresentação responsável pela interface com o usuário contendo a arquitetura de padrão de responsabilidades chamada MVC; <br />
**SalaoDoPantcho.App:** Camada de Aplicação responsável pela comunicação entre o usuário (entidade externa ao sistema) e o sistema propriamente dito. É uma camada fina de intercâmbio entre o usuário e o sistema onde um usuário pode solicitar as funcionalidades do sistema e este (sistema) por sua vez, devolver a resposta de sua solicitação.<br />
**SalaoDoPantcho.Domain:** Camada de Domínio responsável por todas as entidades de negócio, regras e suas características; <br />
**SalaoDoPantcho.Util:** camada baseada no conceito **Cross-Cutting Concerns** e responsável pelas Operações Utilitárias e Secundárias do Sistema; <br />

- Organização do Projeto: na IDE do Visual Studio a organização do projeto está dividida da seguinte forma:<br />
**1 - Camada de Entidades:** a Camada de Entidades contém todas as Entidades (Objetos) de Negócio - Classes e Enums - da Aplicação e suas Regras de Negócio como Associações. **1**<br />
**2 - Camada do Sistema:** a Camada do Sistema subdivide-se em subcamadas a saber:<br />
**2.1 - Camada de Apresentação**<br />
**2.2 - Camada de Aplicação**<br />
**2.3 - Camada de Domínio**<br />
**2.4 - Camada de Infraestrutura**<br />
<p>A Camada de Infraestrutura subdivide-se em subcamadas a saber:<br />

**1**: No DDD - Domain Driven Design disposto por Eric Evans todas as Entidades (Objetos) de Negócio - Classes e Enums - da Aplicação e suas Regras de Negócio como Associações, Restrições e outras Regras ficam dispostas sempre na Camada de Domínio (Domain Layer) da aplicação o que é a maneira padrão de se implementar o DDD - Domain Driven Design.<br />Optei por dispor a Camada de Entidades fora da Camada do Sistema e consequentemente fora da Camada de Domínio (Domain Layer) por essas Entidades (Objetos) de Negócio estarem externos a implementação do sistema pois independente do sistema existir na forma de aplicação, Entidades (Objetos) de Negócio e suas Regras sempre existirão no Contexto de Negócio.<br />
**Cross-Cutting Concerns**: São funcionalidades que não estão diretamente relacionadas ao domínio da aplicação ou às suas respectivas regras de negócio, mas que ainda sim, são importantes para o Software. Exemplos: envio de emails, criptografia de senhas, etc.

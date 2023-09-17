# Injeção de Dependência em .Net Core (Dependency Injection)

**_DI (dependency injection)_** é um padrão de design, uma técnica, do ASP.Net Core que foi criado para alcançar, executar e tornar possível tecnicamente a execução do pattern (padrão de projetos) IoC (Inversion of Control) ou inversão de dependência. 

**Portanto o DI é IoC na prática.**

Uma dependência é um objeto do qual outra classe depende.

Por exemplo, temos a aplicação de uma escola onde temos os alunos e a nota dos alunos. Cada aluno visualizará sua nota nas matérias de matemática e porguês.

Portanto criamos a classe Aluno e a classe NotaAluno.

Na classe **NotaAluno** criamos dois métodos, **NotaMatematica** que exibirá a nota de matemática do aluno e o método **NotaPortugues** que exibirá a nota de português do aluno. Na classe **Aluno** criamos o método **VerNotaAluno**, onde acessamos os métodos dentro da classe **NotaAluno**.

Para a classe **Aluno** acessar os métodos dentro da classe **NotaAluno**, nós precisamos fazer uma instância, ou seja criar um objeto, da classe **NotaAluno** para poder acessar os métodos dentro da classe **NotaAluno**.

**Isso significa que a classe Aluno é uma dependência da classe NotaAluno.**

Vamos ver um exemplo na imagem abaixo.

<p align="center">
  <img src="https://github.com/ThaisGuizardi/dependency-injection/assets/3730961/9d48e4ff-0c90-4f6f-8148-3fa82f853563">
</p>

**Nota:**
Para a classe Aluno ver a classe NotaAluno e os métodos dentro da classe NotaAluno, tanto a classe quanto os métodos precisam estar com seus modificadores de acesso (Access Modifiers) igual a **public**.

Essa dependência conforme exemplificado acima precisa ser evitada para não termos em nossa aplicação um problema que chamamos de **forte acoplamento**. 

Forte acoplamento significa que uma classe para existir depende da existência de outra classe. 

Por exemplo, se por alguma razão precisarmos fazer qualquer modificação na classe NotaAluno, a classe Aluno também precisará ser modificada, ou se até mesmo precisarmos excluir por alguma razão a classe NotaAluno, a classe Aluno precisará também ser modificada.

Agora vamos imaginar esse forte acoplamento em um software gigantesco, com dezenas e centenas de classes, esse processo torna-se praticamente impossível de ser mantido e testado.

**E é nesse momento que o DI no ASP.Net Core entra em ação.**

O que precisamos fazer é o seguinte, primeiro criamos uma Interface ou uma classe base que servirá de abstração para a implementação dessa dependência.
Depois criamos a classe que vamos usar e **injetamos** a Interface no construtor dessa classe.
Por fim, nós vamos até a classe **Program.cs** onde esse processo é normalmente feito (veja o que é a classe Program.cs em **Nota**) e registramos a dependência da Interface com a Classe em um container de serviços.
Isso é possível por que o ASP.Net Core nos fornece uma biblioteca chamada IServiceProvider.
Com isso a estrutura assume a responsabilidade de criar uma instância da dependência e de descartá-la quando não for mais necessária.

Agora vamos fazer um exemplo usando as mesmas classes **Aluno** e **NotaAluno**, mas desta vez será um pouco diferente, criaremos a interface **INotaAluno** e usaremos o padrão de design **DI**.

Criamos um projeto API usando o IDE Visual Studio Community 2022 e o SDK .Net 7, conforme exemplificado na imagem “Projeto VS 2022”.

<p align="center">
  <img src="https://github.com/ThaisGuizardi/dependency-injection/assets/3730961/4bd258db-754f-4985-bd15-3137637a299e" alt="Projeto VS 2022">
  <p align="center"><b><i>Projeto VS 2022</i></b></p>
</p>

Criamos a interface INotaAluno e nesta interface nós adicionamos os métodos NotaMatematica e NotaPortugues. O exemplo está na imagem “Interface INotaAluno”.

<p align="center">
  <img src="https://github.com/ThaisGuizardi/dependency-injection/assets/3730961/bd98309b-eae6-4035-956c-65fb6f62fd50" alt="Interface INotaAluno">
  <p align="center"><b><i>Interface INotaAluno</i></b></p>
</p>

Alteramos a classe NotaAluno para que ela herdasse a interface INotaAluno, conforme mostrado na imagem “Classe NotaAluno”.

<p align="center">
  <img src="https://github.com/ThaisGuizardi/dependency-injection/assets/3730961/cd887c91-5542-4a4b-b3e8-dafb9a175d92" alt="Classe NotaAluno">
  <p align="center"><b><i>Classe NotaAluno</i></b></p>
</p>

Agora vamos até a classe Program.cs e **registramos a dependência da interface INotaAluno com a classe NotaAluno**, exemplificado na imagem “Registro de Dependência”.

<p align="center">
  <img src="https://github.com/ThaisGuizardi/dependency-injection/assets/3730961/b8e6fdc1-c205-4382-94e7-7a52568c902a" alt="Registro de Dependência">
  <p align="center"><b><i>Registro de Dependência</i></b></p>
</p>

E por fim vamos até a classe Aluno, injetamos a interface INotaAluno no construtor da classe Aluno e invocamos os métodos NotaMatematica e NotaPortugues através da variável criada para nomear a interface INotaAluno, como mostrado na imagem “Classe Aluno”.

<p align="center">
  <img src="https://github.com/ThaisGuizardi/dependency-injection/assets/3730961/79ae5081-2d85-4419-950b-3ad3a981fd2f" alt="Classe Aluno">
  <p align="center"><b><i>Classe Aluno</i></b></p>
</p>

**Nota:** A classe Program.cs é uma classe padrão ASP.Net Core criada automaticamente quando criamos um novo projeto Web e nesta classe configuramos os serviços exigidos pela aplicação.

## Pré-requisitos

- Visual Studio 2022 Community: https://visualstudio.microsoft.com/pt-br/vs/community/
- .NET 7.0: https://dotnet.microsoft.com/en-us/download/dotnet/7.0

## Palavras chave
- IDE - Integrated Development Environment (Ambiente de Desenvolvimento Integrado)
- SDK - Software Development Kit (Kit de Desenvolvimento de Software)
- API - Application programming interface (Interface de programação de aplicações)
- Classe
- Objeto
- Método
- Instância
- Public
- Interface
- Construtor
- Variável
- Container de Serviços
- Fortemente acoplada
- Pattern - Padrão (padrão de projetos).
- IoC - Inversion of Control (Inversão de controle ou inversão de dependência).
- Modificadores de acesso - Access modifiers

## Contato Linked-in

- www.linkedin.com/in/thaisguizardi

## Referências
- Microsoft Learn: https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0
- Microsoft Learn: https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/?view=aspnetcore-7.0&tabs=windows

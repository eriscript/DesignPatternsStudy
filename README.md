# 📚 DesignPatternsStudy

Este repositório é um projeto de estudo prático dos **23 padrões de projeto (Design Patterns)** da **Gang of Four (GoF)**, organizados por categoria e implementados em **.NET (C#)** com exemplos em uma **Web API ASP.NET**.

---

## 🎯 Objetivo

Fornecer implementações simples, comentadas e funcionais dos padrões de projeto, visando o aprendizado prático com exemplos reais e de fácil entendimento.

---

## 🧱 Estrutura do Projeto

```text
DesignPatternsStudy/
├── Behavioral/ # Padrões Comportamentais (em breve)
├── Common/ # Interfaces e utilitários comuns
├── Creational/ # Padrões Criacionais
│ ├── SingletonPattern/
│ ├── FactoryMethodPattern/
│ ├── AbstractFactoryPattern/
│ ├── BuilderPattern/
│ └── PrototypePattern/
├── Structural/ # Padrões Estruturais
│ ├── AdapterPattern/ ✅
│ ├── BridgePattern/ ✅
│ ├── CompositePattern/ ✅
│ ├── DecoratorPattern/ ✅
│ ├── FacadePattern/ ✅
│ ├── FlyweightPattern/ ✅
│ └── ProxyPattern/ ✅
├── WebApi/
├── .gitignore
├── DesignPatternsStudy.sln
├── LICENSE
└── README.md
```

---

## ✅ Padrões já implementados

### 🔹 Structural

```text
| Padrão    | Descrição                                                                |
| --------- | ------------------------------------------------------------------------ |
| Adapter   | Adapta uma interface de uma classe para o formato esperado pelo cliente. |
| Bridge    | Separa abstração da implementação, permitindo independência entre elas.  |
| Composite | Compõe objetos em estruturas de árvore para representar hierarquias.     |
| Decorator | Adiciona funcionalidades a objetos dinamicamente.                        |
| Facade    | Fornece uma interface simplificada para um subsistema complexo.          |
| Flyweight | Compartilha objetos para suportar grandes quantidades de dados.          |
| Proxy     | Controla o acesso a outro objeto, podendo adicionar lógica extra.        |
```

---

## 🔧 Como executar

1. Clone o repositório:

   ```bash
   git clone https://github.com/eriscript/DesignPatternsStudy.git
   ```

2. Acesse a pasta do projeto:

   ```bash
   cd DesignPatternsStudy
   ```

3. Restaure os pacotes e compile a solution:

   ```bash
   dotnet restore
   dotnet build
   ```

4. Execute a Web API para testes:

   ```bash
   cd WebApi
   dotnet run
   ```

## 📬 Exemplos de chamadas de API

- **ProxyPattern**<br>
  `GET http://localhost:5278/clima/São%20Paulo`

- **AdapterPattern**<br>
  `POST http://localhost:5278/notificacao?para=email@teste.com&mensagem=Olá`

  (Os endpoints variam conforme o padrão)

## 👨‍💻 Autor

**Erismar Nascimento**<br>
Desenvolvedor .NET | Entusiasta de Arquitetura de Software

## 📝 Licença

Este projeto é licenciado sob a [MIT License](https://opensource.org/license/mit).

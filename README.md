# 🍽️ **Restaurant Solution - Microservices Architecture Study**

Este projeto é um **ecossistema completo de microserviços** desenvolvido para estudar e praticar os conceitos de **arquitetura de software**, **microserviços** e **integração de APIs**. O sistema simula uma aplicação de restaurante, com um front-end desenvolvido em **Blazor WebAssembly** e back-end composto por três APIs independentes.

O objetivo é explorar as melhores práticas de desenvolvimento, incluindo **clean code**, **design patterns**, e tecnologias modernas como .NET 8, Dapper, e MediaR (CQRS).

---

## 🎯 **Objetivo do Projeto**
- Aprender na prática os fundamentos de **microserviços**.
- Desenvolver um front-end desacoplado com **Blazor WebAssembly**, que consome APIs.
- Implementar conceitos de **segurança**, **autenticação JWT**, e **logs centralizados**.
- Configurar comunicação entre serviços utilizando **mensageria** (RabbitMQ ou afins).
- Experimentar integrações e deploys locais com **Docker**.

---

## 📂 **Estrutura do Projeto**
A solução está organizada em múltiplos serviços, divididos da seguinte forma:

### **Microserviços**
- **Order Service**: Gerencia pedidos feitos no restaurante, incluindo criação e acompanhamento.
- **Product Service**: Cuida do cadastro e gerenciamento de produtos do cardápio.
- **Payment Service**: Processa pagamentos e validações financeiras.

### **Front-end**
- **Blazor WebAssembly**: Aplicação cliente SPA (Single Page Application) que consome as APIs dos microserviços.

### **Shared Kernel**
- Biblioteca compartilhada entre os serviços, contendo:
  - Modelos de dados.
  - Contratos de API.
  - Classes utilitárias.

---

## 🛠️ **Tecnologias Utilizadas**
- **Back-end**:
  - .NET 8 (C#)
  - EF para acesso ao banco de dados.
  - Autenticação via JWT.
- **Front-end**:
  - Blazor WebAssembly (SPA).
- **Mensageria**:
  - RabbitMQ (planejado para comunicação entre serviços).


## 📝 **Funcionalidades Planejadas**
- Integração entre os microserviços via RabbitMQ.
- Logs centralizados com ferramentas como Serilog ou Elastic Stack.
- CI/CD com GitHub Actions para automação de testes e deploys.
- Autenticação e autorização para o front-end e APIs.

---

## 📌 **Contribuições**
Sinta-se à vontade para sugerir melhorias, abrir issues ou enviar pull requests. Este projeto é totalmente open-source e focado em aprendizado colaborativo.

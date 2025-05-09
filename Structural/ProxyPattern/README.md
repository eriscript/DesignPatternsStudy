# 🧠 O que é o Proxy Pattern?

O **Proxy Pattern** fornece um substituto ou representante para controlar o acesso a um objeto. É útil para adicionar funcionalidades (como cache, autenticação, ou logging) sem modificar a lógica principal do serviço.

## 🧪 Exemplo prático: **Serviço de Clima com Proxy de Cache**

Teremos:

- Um serviço principal que busca dados de clima.

- Um proxy que adiciona **cache** e **logging**.

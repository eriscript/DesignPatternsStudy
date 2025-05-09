# 🧠 O que é o Adapter Pattern?

O **Adapter Pattern** permite que duas interfaces incompatíveis trabalhem juntas. Ele converte a interface de uma classe em outra esperada pelos clientes, funcionando como um **"tradutor"**.

## 🧪 Exemplo prático: **Sistema que usa um serviço legado de envio de mensagens**

- O sistema espera uma interface `INotificador`.

- Temos uma classe legada `EmailLegacyService` que não implementa essa interface.

- O Adapter faz a ponte entre os dois.

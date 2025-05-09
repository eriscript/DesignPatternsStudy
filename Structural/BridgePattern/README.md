# 🧠 O que é o padrão Bridge?

O **Bridge Pattern** desacopla uma abstração da sua implementação, permitindo que os dois evoluam independentemente.

## 📘 Exemplo prático: **Notificações**

- Abstração: Notificação (`Notificacao`)

- Implementações: Enviar por Email, SMS etc. (`INotificador`)

- Bridge: A abstração usa uma interface que pode ter várias implementações.

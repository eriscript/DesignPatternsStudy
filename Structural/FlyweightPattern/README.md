# 🧠 O que é o Flyweight Pattern?

O **Flyweight Pattern** é usado para minimizar o uso de memória compartilhando o máximo possível de dados com outros objetos semelhantes. Ele é ideal quando lidamos com um grande número de objetos com partes de dados que podem ser reutilizadas.

## 💡 Exemplo prático: **Carros em um pátio**

Suponha que estamos simulando milhares de carros em um pátio. Cada carro possui:

- **Dados extrínsecos** (mudam por instância): placa, posição.

- **Dados intrínsecos** (compartilhados): modelo, cor, fabricante.

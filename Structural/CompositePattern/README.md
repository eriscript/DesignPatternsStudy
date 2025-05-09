# 🧠 O que é o Composite Pattern?

O padrão **Composite** permite compor objetos em estruturas de árvore e trabalhar com esses objetos de forma uniforme. Ideal para representar **hierarquias**.

## 📘 Exemplo prático: Sistema de Arquivos

- **Componente**: `IArquivo`

- **Folha**: `Arquivo`

- **Composite**: `Diretorio` (que pode conter `Arquivo` e outros `Diretorio`)

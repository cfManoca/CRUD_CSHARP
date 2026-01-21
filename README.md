# CRUD_CSHARP

Essa é uma Aplicação web ASP.NET Core MVC que implementa um (CRUD) simples para gerenciamento de **Motoristas** e **Carros**.

O objetivo dessa aplicação é testar suas habilidades, vendo sua capacidade em usar o que já foi introduzido no projeto com criativade para:

- Implementar o CRUD completo de **Carros** no `Controllers/CarrosController.cs` seguindo o mesmo padrão implentado em `MotoristasController`.
- Criar as Views em `Views/Carros` (`Index`, `Details`, `Create`, `Edit`, `Delete`) deixando totalmente funcional.

## Requisitos

- **.NET SDK:** `9.0.x`
- **Git** (para clonar o repositório)
- IDE recomendada (opcional):
  - Visual Studio

## Como baixar o projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/kas-oss/CRUD_CSHARP.git
   cd CRUD_CSHARP
   ```

## Como entregar o resultado:

Este repositório é público e aceita contribuições via Pull Request.

1. Faça um fork do repositório no GitHub.
2. Clone o seu fork e crie uma branch:
   ```bash
   git clone https://github.com/<seu-usuario>/CRUD_CSHARP.git
   cd CRUD_CSHARP
   git checkout -b feature/seu-nome
   ```
3. Rode o projeto localmente e verifique se tudo está ok:
   ```bash
   dotnet restore
   dotnet build
   dotnet run
   ```
4. Implemente sua melhoria (ex.: CRUD de `Carros` + views em `Views/Carros`).
5. Faça commits pequenos e descritivos e envie para o seu fork:
   ```bash
   git add .
   git commit -m "Implementa CRUD de Carros"
   git push -u origin feature/seu-tema
   ```
6. Abra um Pull Request para a branch `main` deste repositório:
   - Descreva o que foi feito.

## Rotas principais

- Home: `/`
- Motoristas: `/Motoristas`
- Carros: `/Carros` (pendente)

## Observações

- Persistência atual é **em memória** (os dados são perdidos ao reiniciar a aplicação).

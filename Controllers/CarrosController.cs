using CRUD_CSHARP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_CSHARP.Controllers;

public class CarrosController : Controller
{
    // EXPECTATIVA DO TESTE:
    // - Implementar um CRUD completo para Carro, seguindo o mesmo padrão do MotoristasController.
    // - Pode ser persistência em memória (List<Carro> estática) como Motoristas, ou outra estratégia do projeto.
    // - Criar as Views em Views/Carros (Index, Details, Create, Edit, Delete).
    // - Adicionar um link no menu/layout para navegar para /Carros.
    //
    // Dica: o Carro já está modelado em Models/Carro.cs e o enum em Models/TipoCombustivel.cs.

    public IActionResult Index()
    {
        // TODO (candidato):
        // - Buscar/listar carros
        // - Ordenar (ex.: por Marca/Modelo ou Placa)
        // - Retornar View(lista)
        throw new NotImplementedException();
    }

    public IActionResult Details(int id)
    {
        // TODO (candidato):
        // - Buscar carro por id
        // - Se não existir, retornar NotFound()
        // - Retornar View(carro)
        throw new NotImplementedException();
    }

    public IActionResult Create()
    {
        // TODO (candidato):
        // - Retornar a tela de cadastro
        // - (Opcional) Preparar dropdown de combustível (TipoCombustivel)
        throw new NotImplementedException();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Carro carro)
    {
        // TODO (candidato):
        // - Validar ModelState
        // - Gerar Id (se usar lista em memória)
        // - Persistir o carro
        // - RedirectToAction(nameof(Index))
        throw new NotImplementedException();
    }

    public IActionResult Edit(int id)
    {
        // TODO (candidato):
        // - Buscar carro por id
        // - Se não existir, retornar NotFound()
        // - Retornar View(carro)
        throw new NotImplementedException();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Carro carro)
    {
        // TODO (candidato):
        // - Validar se id == carro.Id (senão NotFound/BadRequest)
        // - Validar ModelState
        // - Atualizar dados do carro persistido
        // - RedirectToAction(nameof(Index))
        throw new NotImplementedException();
    }

    public IActionResult Delete(int id)
    {
        // TODO (candidato):
        // - Buscar carro por id
        // - Se não existir, retornar NotFound()
        // - Retornar View(carro) para confirmação
        throw new NotImplementedException();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id, Carro carro)
    {
        // TODO (candidato):
        // - Remover o carro persistido pelo id
        // - Se não existir, retornar NotFound()
        // - RedirectToAction(nameof(Index))
        throw new NotImplementedException();
    }
}

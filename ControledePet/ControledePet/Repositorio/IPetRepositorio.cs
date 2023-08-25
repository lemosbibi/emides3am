using ControledePet.Models;

namespace ControledePet.Repositorio
{
    public interface IPetRepositorio
    {
        List<PetModel> BuscarTodos();
        PetModel Adicionar(PetModel pet);
        PetModel Atualizar(PetModel pet);
        
    }
}

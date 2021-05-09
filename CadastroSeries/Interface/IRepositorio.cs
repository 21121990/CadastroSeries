using System.Collections.Generic;


namespace CadastroSeries
{

    public interface IRepositorio<T>
    {
         List<T> Lista();

         T retornaPorID(int id);  
         void Insert (T entidade);
         void Excluir (int id);
         void Atualizar(int id, T entidade);
         int ProximoId(); 
    }
}
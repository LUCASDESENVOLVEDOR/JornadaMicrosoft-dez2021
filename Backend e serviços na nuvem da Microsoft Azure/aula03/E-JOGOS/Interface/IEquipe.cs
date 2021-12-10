using E_JOGOS.Models;
using System.Collections.Generic;

namespace E_JOGOS.Interface
{
    /// <summary>
    /// RESPONSÁVEL POR DETERMINAR QUAIS METODOS UMA CLASSE TERÁ
    /// É O CONTRATO DA CLASSE.
    /// </summary>
    public interface IEquipe
    {
        //CREATE
        //READALL
        //UPDATE
        //DELETE

        void Create(Equipe nova_equipe);
        List<Equipe> ReadAll();
        void Update(Equipe equipe);
        void Delete(int idEquipe);      
    }
}

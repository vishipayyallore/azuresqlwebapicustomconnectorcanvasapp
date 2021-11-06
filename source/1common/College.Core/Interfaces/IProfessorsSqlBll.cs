using College.Core.Entities;

namespace College.Core.Interfaces
{

    public interface IProfessorsSqlBll
    {
        Task<IEnumerable<Professor>> GetAllProfessors();
    }

}

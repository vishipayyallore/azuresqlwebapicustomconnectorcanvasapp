using College.Core.Entities;

namespace College.Core.Interfaces
{

    public interface IProfessorsSqlDal
    {
        Task<IEnumerable<Professor>> GetAllProfessors();
    }

}

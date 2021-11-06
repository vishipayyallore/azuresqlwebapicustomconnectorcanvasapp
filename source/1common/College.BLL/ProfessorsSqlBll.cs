﻿using College.Core.Entities;
using College.Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace College.BLL
{

    public class ProfessorsSqlBll : IProfessorsSqlBll
    {
        private readonly IProfessorsSqlDal _professorsSqlDal;
        private readonly ILogger<ProfessorsSqlBll> _logger;

        public ProfessorsSqlBll(IProfessorsSqlDal professorsSqlDal, ILogger<ProfessorsSqlBll> logger)
        {
            _professorsSqlDal = professorsSqlDal ?? throw new ArgumentNullException(nameof(professorsSqlDal));

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<Professor>> GetAllProfessors()
        {
            _logger.Log(LogLevel.Debug, "Request Received for ProfessorsSqlBll::GetAllProfessors");

            var allProfessors = await _professorsSqlDal.GetAllProfessors();

            _logger.Log(LogLevel.Debug, "Returning the results from ProfessorsSqlBll::GetAllProfessors");

            return allProfessors;
        }

    }

}

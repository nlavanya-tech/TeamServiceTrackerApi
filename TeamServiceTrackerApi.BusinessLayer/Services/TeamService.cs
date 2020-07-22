using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamServiceTrackerApi.BusinessLayer.Interface;
using TeamServiceTrackerApi.BusinessLayer.Services.Repository;
using TeamServiceTrackerApi.Entities;

namespace TeamServiceTrackerApi.BusinessLayer.Services
{
   public class TeamService : ITeamService
    {
        //creating instance of teamrepository
        private readonly ITeamRepository _repository;
        public TeamService(ITeamRepository repository)
        {
            _repository = repository;
        }

        //Get teams and retrun list of teams
        public async Task<IEnumerable<Teams>> TeamReadAsync()
        {
            var teams = await _repository.TeamReadAsync();

            return teams;
        }

        //Create teams
        public async Task<Teams> TeamCreateAsync(Teams teams)
        {
            await _repository.TeamCreateAsync(teams);
            return teams;
        }

        //Update teams
        public async Task<Teams> TeamUpdateAsync(Teams teams)
        {
            var note = await _repository.TeamUpdateAsync(teams);

            return note;
        }

        //Delete teams 
        public async Task<bool> TeamDeleteAsync(string teamname)
        {
            var result = await _repository.TeamDeleteAsync(teamname);
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamBrowserBL.Models;
using TeamBrowserBL.DataAccess;

namespace TeamBrowserBL.Services
{
    public class TeamService
    {
        public static Team insert(String name)
        {
            try{
                var context = new TeamBrowserDBDataContext();
                var team = new Team() { 
                    name = name
                };
                context.Teams.InsertOnSubmit(team);
                context.SubmitChanges();

                return team;
            }catch(Exception ex){
                throw ex;
            }
        }

        public static Team update(int id, String name)
        {
            try
            {
                var context = new TeamBrowserDBDataContext();
                var team = context.Teams.Single(t => t.id == id);
                if (team != null){
                    team.name = name;
                    context.SubmitChanges();
                }

                return team;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void delete(int id)
        {
            try
            {
                var context = new TeamBrowserDBDataContext();
                var team = context.Teams.Single(t => t.id == id);
                if(team != null){
                    context.Teams.DeleteOnSubmit(team);
                    context.SubmitChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Team find(int teamId) {
            try
            {
                var context = new TeamBrowserDBDataContext();
                return context.Teams.SingleOrDefault(t => t.id == teamId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Team> list()
        {
            try
            {
                var context = new TeamBrowserDBDataContext();
                var result = (from t in context.Teams select t);
                return result.ToList<Team>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

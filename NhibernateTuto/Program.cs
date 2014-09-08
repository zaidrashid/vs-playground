using NHibernate;
using NhibernateTuto.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateTuto
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using (var isession = NHibernateHelper.CreateSessionFactory2())
            {

                //Console.ReadLine();
                using (var session = isession.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        try
                        {
                            Team team1 = new Team();
                            team1.teamID = 1;
                            team1.teamName = "Team 3";

                            Team team2 = new Team();
                            team2.teamID = 2;
                            team2.teamName = "Team 4";

                            List<Team> teamList = new List<Team>();
                            teamList.Add(team1);
                            teamList.Add(team2);

                            Customer cust = new Customer();
                            cust.Id = 1;
                            cust.FirstName = "Cust Name 2";
                            cust.teamList = teamList;

                            Customer cust1 = new Customer();
                            cust1.Id = 2;
                            cust1.FirstName = "Cust Name 3";
                            cust1.teamList = teamList;


                            session.Save(team1);
                            session.Save(team2);
                            session.Save(cust);
                            session.Save(cust1);
                            transaction.Commit();

                            //IList<Customer> customersearch = session.CreateCriteria(typeof(Customer)).List<Customer>().SingleOrDefault(c => c.Id == 2);

                            //Customer customerfind = new Customer();
                            //customerfind = session.CreateCriteria(typeof(Customer)).List<Customer>().SingleOrDefault(c => c.Id == 1);
                        }
                        catch (Exception ex)
                        {
                            
                            throw;
                        }

                    }
                }


            }

            Console.ReadLine();
        }
    }
}

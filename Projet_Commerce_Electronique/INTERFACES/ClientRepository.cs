using Clinique_CF.INTERFACES;
using Projet_Commerce_Electronique.MODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Commerce_Electronique.INTERFACES
{
    public class ClientRepository : IGeniricRepository<Client>
    {
        private readonly CommerceDbContext _context;

        public ClientRepository()
        {
            _context = new CommerceDbContext();
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public Client getByID(int id)
        {
            return _context.Clients.Find(id);
        }

        public void insert(Client entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
        }

        public void update(Client entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void deleteByID(Client entity)
        {
            _context.Clients.Remove(entity);
            _context.SaveChanges();
        }
    }
}

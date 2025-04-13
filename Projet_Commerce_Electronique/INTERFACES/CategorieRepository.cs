using Clinique_CF.INTERFACES;
using Projet_Commerce_Electronique.MODELS;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Commerce_Electronique.INTERFACES
{
    public class CategorieRepository : IGeniricRepository<Categorie>
    {
        private readonly CommerceDbContext _context;

        public CategorieRepository()
        {
            _context = new CommerceDbContext();
        }

        public IEnumerable<Categorie> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Categorie getByID(int id)
        {
            return _context.Categories.Find(id);
        }

        public void insert(Categorie entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }

        public void update(Categorie entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void deleteByID(Categorie entity)
        {
            _context.Categories.Remove(entity);
            _context.SaveChanges();
        }

        
    }
}

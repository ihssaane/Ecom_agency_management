using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique_CF.INTERFACES;
using Clinique_CF.REPOSITORY;
using Projet_Commerce_Electronique.MODELS;

namespace Projet_Commerce_Electronique.CONTROLLERS
{
    public class ProduitController
    {
        private readonly IGeniricRepository<Produit> produitRepository;

        public ProduitController()
        {
            this.produitRepository = new GeniricRepository<Produit>(new CommerceDbContext());
        }

        public void AjouterProduit(Produit produit)
        {
            try
            {
                produitRepository.insert(produit);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l'ajout du produit dans la base de données: " + ex.Message);
            }
        }

        public List<Produit> GetAllProduits()
        {
            return produitRepository.GetAll().ToList();
        }

        public Produit GetProduitById(int id)
        {
            return produitRepository.getByID(id);
        }

        public void UpdateProduit(Produit produit)
        {
            produitRepository.update(produit);
        }

        public void DeleteProduit(Produit produit)
        {
            produitRepository.deleteByID(produit);
        }
    }
}

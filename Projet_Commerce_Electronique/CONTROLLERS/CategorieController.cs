using System;
using System.Collections.Generic;
using System.Linq;

using Clinique_CF.INTERFACES;
using Clinique_CF.REPOSITORY;
using Projet_Commerce_Electronique.MODELS;

namespace Projet_Commerce_Electronique.CONTROLLERS
{
    public class CategorieController
    {
        private readonly IGeniricRepository<Categorie> categorieRepository;

        public CategorieController(IGeniricRepository<Categorie> categorieRepository)
        {
            this.categorieRepository = new GeniricRepository<Categorie>(new CommerceDbContext());
        }

        public void AjouterCategorie(Categorie categorie)
        {
            try
            {
                categorieRepository.insert(categorie);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l'ajout de la catégorie dans la base de données: " + ex.Message);
            }
        }

        public List<Categorie> GetAllCategories()
        {
            return categorieRepository.GetAll().ToList();
        }

        public Categorie GetCategorieById(int id)
        {
            return categorieRepository.getByID(id);
        }

        public void UpdateCategorie(Categorie categorie)
        {
            try
            {
                categorieRepository.update(categorie);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la mise à jour de la catégorie: " + ex.Message);
            }
        }

        public void DeleteCategorie(Categorie categorie)
        {
            try
            {
                categorieRepository.deleteByID(categorie);
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la suppression de la catégorie: " + ex.Message);
            }
        }

     
        public Categorie GetCategorieWithProduits(int id)
        {
         
            var categorie = categorieRepository.getByID(id);
            return categorie;
        }
    }
}

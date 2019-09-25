using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entity;
using Entity.Contracts;

namespace Business
{
    public static class DatabaseInitializer
    {
        private static bool hasInitialized;

        public static void InitializeDB()
        {
            if (!hasInitialized)
            {
                NeighlinkDBContext context = new NeighlinkDBContext();

                List<Plan> plans = context.Plans.ToList();
                //Esto es solo por si la base de datos esta vacia. La prueba podria ser mas completa pero
                //Para nuestros propositos esto esta bien
                if (plans == null || plans.Count == 0)
                {
                    CreateInitialDBStructure(context);
                }

                hasInitialized = true;
            }
        }

        private static void CreateInitialDBStructure(NeighlinkDBContext context)
        {
            //Creamos el plan
            Plan corePlan = new Plan();
            corePlan.Type = PlanType.Core;
            corePlan.Description = "Standard Plan";

            //Creamos el condo
            Condominium condominium = new Condominium();
            condominium.Name = "Re";
            condominium.SecretCode = "Cafe Tacuba";
            condominium.Address = "Ciudad Satélite, Mexico";
            condominium.PhotoUrl = "https://en.wikipedia.org/wiki/Re_(Caf%C3%A9_Tacuba_album)#/media/File:Caf%C3%A9_Tacuba_Re.jpg";

            //Creamos un par de buildings
            Building lasFlores = new Building();
            lasFlores.Name = "Las Flores";
            lasFlores.NumberOfHomes = 5;
            lasFlores.Description = "Romantica";

            Building ingrata = new Building();
            ingrata.Name = "Ingrata";
            ingrata.NumberOfHomes = 2;
            ingrata.Description = "Romantica";

            //Creamos el rol
            Role role = new Role();
            role.Type = UserRole.Administrator;
            role.Description = "Los que mandan";

            //Creamos el usuario
            User user = new User();
            user.FirstName = "Ruben";
            user.LastName = "Albarran";
            user.PhoneNumber = "12120";
            user.BirthDate = new DateTime(1967, 2, 1);
            user.PhotoUrl = "https://es.wikipedia.org/wiki/Rub%C3%A9n_Albarr%C3%A1n#/media/Archivo:Rub%C3%A9n_Albarr%C3%A1n.jpg";
            user.Gender = Gender.Male;
            user.Email = "cosme@cafetacuba.com";

            //linkeamos todo
            role.Users = new List<User>() { user };
            condominium.Roles = new List<Role>() { role };
            condominium.Buildings = new List<Building>() { lasFlores, ingrata };
            corePlan.Condominiums = new List<Condominium>() { condominium };

            context.Plans.Add(corePlan);
            context.SaveChanges();
        }
    }
}

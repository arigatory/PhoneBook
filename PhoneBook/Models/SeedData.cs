using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PhoneBookDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<PhoneBookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Contacts.Any())
            {
                context.Contacts.AddRange(
                    new Contact { 
                        Address="г. Москва, ул. Летная, д. 8",
                        LastName="Иванов",
                        FirstName="Игорь",
                        MiddleName="Алексеевич",
                        Phone="+7(905)484-34-34",
                        Description="друг моего отца"
                        },
                    new Contact
                    {
                        Address = "г. Санкт-Петербург, ул. Нелетная, д. 55",
                        LastName = "Сахаров",
                        FirstName = "Игорь",
                        MiddleName = "Алексеевич",
                        Phone = "+7(805)484-00-34",
                        Description = "друг моего друга"
                    },
                    new Contact
                    {
                        Address = "г. Москва, ул. Летная, д. 9",
                        LastName = "Виноградова",
                        FirstName = "Елена",
                        MiddleName = "Ивановна",
                        Phone = "+7(999)555-34-44",
                        Description = "подруг моей мамы"
                    },
                    new Contact
                    {
                        Address = "г. Москва, ул. Центральная, д. 87",
                        LastName = "Петрова",
                        FirstName = "Анастасия",
                        MiddleName = "Олеговна",
                        Phone = "+7(906)484-34-00",
                        Description = "подруга моего отца"
                    });
                context.SaveChanges();
            }
        }
    }
}

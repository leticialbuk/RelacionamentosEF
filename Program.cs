using RelacionamentosEF.Data;
using RelacionamentosEF.Models;
using System;

namespace RelacionamentosEF
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Bio = "L",
                Email = "leticia@albuk.com",
                GitHub = "leticialbuk",
                Image = "https:/",
                Name = "Leticia Albuquerque",
                PasswordHash = "1234",
                Slug = "leticia-albuk"
            };

            using var context = new DataContext();
            context.Users.Add(user);
            context.SaveChanges();  
        }
    }
}
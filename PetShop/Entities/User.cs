﻿namespace PetShopAPI.Entities
{
    public class User
    {
        public int Id { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Nationality { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
    }
}

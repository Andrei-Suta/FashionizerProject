﻿using FashionizerProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionizerProject.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem item);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
        Task EmptyCart();
    }
}
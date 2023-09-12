﻿using APIAlura.Entity;
using APIAlura.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APIAlura.Repository
{
    public class EFUsuarioRepository : EFRepository<Usuario>, IUsuarioRepository
    {
        public EFUsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Usuario ObterComPedidos(int id)
        {
            return _context.Usuario
                .Include(u => u.Pedidos)
                .Where(u => u.Id == id)
                .ToList()
                .Select(usuario =>
                {
                    usuario.Pedidos = usuario.Pedidos.Select(pedido => new Pedido(pedido)).ToList();
                    return usuario;
                }).FirstOrDefault();
        }
    }
}

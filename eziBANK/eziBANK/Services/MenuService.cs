using System;
using System.Collections.Generic;
using eziBANK.Model;

namespace eziBANK.Services
{
    public class MenuService
    {
        public List<MenuModel> GetItensMenu()
        {

            return new List<MenuModel>
            {
                new MenuModel { Id=1, Imagem = "pagamentos.png", Texto="Pagamentos" },
                new MenuModel { Id=2, Imagem = "cartao.png", Texto="Cartões" },
                new MenuModel { Id=3, Imagem = "transferencia.png", Texto="Transferências"},
                new MenuModel { Id=4, Imagem = "sino.png" , Texto="Notificações"},
                new MenuModel { Id=5, Imagem = "SAIR.png", Texto="Sair" },
            };

        }
    }
}
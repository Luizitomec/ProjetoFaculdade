﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFaculdade.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string ProdutoPreco { get; set; }
        public int Quantidade { get; set; }
    }
}

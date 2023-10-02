using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Models
{
    public class Usuario
    {
        private EnumFaixaEtaria _enumFaixaEtaria;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        private Enum FaixaEtaria 
        { 
            get 
            {
                switch (Idade)
                {
                    case <= 2:
                        return  EnumFaixaEtaria.Bebe;
                    case <= 10:
                        return EnumFaixaEtaria.Crianca;
                    case <= 14:
                        return EnumFaixaEtaria.PreAdolescente;
                    case <= 17:
                        return EnumFaixaEtaria.Adolescente;
                    case <= 24:
                        return EnumFaixaEtaria.JovemAdulto;
                    case <= 60:
                        return EnumFaixaEtaria.Adulto;
                    case <= 80:
                        return EnumFaixaEtaria.Idoso;
                    case > 80:
                        return EnumFaixaEtaria.Geriatrico;
                    default:
                        return EnumFaixaEtaria.Indefinidoe;
                }                                          
            } 
        }
    }
}
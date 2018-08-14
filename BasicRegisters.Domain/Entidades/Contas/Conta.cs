﻿using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicRegisters.Domain.Entidades.Contas
{
    public class Conta : IConta
    {
        public string Apelido { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public DateTime? DataDeExclusao { get; set; }
        public bool? Excluido { get; set; }
        public Guid Id { get; set; }
        public string Nome { get; set; }

        [NotMapped]
        public Usuario UsuarioDeCadastro { get; set; }

        public Guid? UsuarioDeCadastroId { get; set; }

        [NotMapped]
        public Usuario UsuarioDeExlusao { get; set; }

        public Guid? UsuarioDeExlusaoId { get; set; }
    }
}
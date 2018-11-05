﻿using EP.CursoMvc.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Entitites;
using EP.CursoMvc.Domain.Interfaces.Repository;
using EP.CursoMvc.Domain.Validations.Clientes;

namespace EP.CursoMvc.Domain.Services
{
    public class FiliacaoService : IFiliacaoService
    {
        private readonly IFiliacaoRepository _filiacaoRepository;

        public FiliacaoService(IFiliacaoRepository filiacaoRepository)
        {
            _filiacaoRepository = filiacaoRepository;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            if (!cliente.EhValido()) return cliente;

            cliente.ValidationResult = new ClienteAptoParaCadastroValidation(_filiacaoRepository).Validate(cliente);

            return !cliente.ValidationResult.IsValid ? cliente : _filiacaoRepository.Adicionar(cliente);
        }

        public Cliente Atualizar(Cliente cliente)
        {
            return _filiacaoRepository.Atualizar(cliente);
        }        

        public IEnumerable<Cliente> ObterAtivos()
        {
            return _filiacaoRepository.ObterAtivos();
        }

        public Cliente ObterPorCpf(string cpf)
        {
            return _filiacaoRepository.ObterPorCpf(cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _filiacaoRepository.ObterPorEmail(email);
        }

        public Cliente ObterPorId(Guid id)
        {
            return _filiacaoRepository.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _filiacaoRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _filiacaoRepository.Remover(id);
        }

        public void Dispose()
        {
            _filiacaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

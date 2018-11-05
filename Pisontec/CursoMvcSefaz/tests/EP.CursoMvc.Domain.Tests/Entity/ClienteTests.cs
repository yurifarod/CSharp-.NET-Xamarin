using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EP.CursoMvc.Domain.Entitites;
using System.Linq;

namespace EP.CursoMvc.Domain.Tests.Entity
{
    [TestClass]
    public class ClienteTests
    {
        [TestMethod]
        public void Cliente_SelfValidation_IsValid()
        {
            var cliente = new Cliente
            {
                CPF = new Value_Objects.CPF { Numero = "13690042658" },
                Email = new Value_Objects.Email { Endereco = "cassiano@cassiano.com " },
                DataNascimento = new DateTime(1980, 01, 01)
            };

            var result = cliente.EhValido();

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Cliente_SelfValidation_IsNotValid()
        {
            var cliente = new Cliente
            {
                CPF = new Value_Objects.CPF { Numero = "1369004268" },
                Email = new Value_Objects.Email { Endereco = "cassianocassiano.com " },
                DataNascimento = new DateTime(2016, 01, 01)
            };

            var result = cliente.EhValido();

            Assert.IsFalse(result);

            Assert.IsTrue(cliente.ValidationResult.Erros.Any(e => e.Message.Contains("CPF")));
            Assert.IsTrue(cliente.ValidationResult.Erros.Any(e => e.Message.Contains("E-mail")));
            Assert.IsTrue(cliente.ValidationResult.Erros.Any(e => e.Message.Contains("idade")));
        }
    }
}

using AtvFormsComp.model;
using AtvFormsComp.repository;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ContaPoupancaService
    {
        public static ContaPoupanca addContaPoupanca(ContaPoupanca conta)
        {
            return ContaPoupancaRepository.addContaPoupanca(conta);
        }

        public static List<ContaPoupanca> getContasPoupanca()
        {
            return ContaPoupancaRepository.getContasPoupanca();
        }
    }
}

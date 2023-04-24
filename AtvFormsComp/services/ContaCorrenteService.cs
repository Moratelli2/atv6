using AtvFormsComp.model;
using AtvFormsComp.repository;
using System.Collections.Generic;

namespace AtvFormsComp.services
{
    class ContaCorrenteService
    {
        public static ContaCorrente addContaCorrente(ContaCorrente contaCorrente)
        {
            return ContaCorrenteRepository.addContaCorrente(contaCorrente);
        }

        public static List<ContaCorrente> GetContasCorrentes()
        {
            return ContaCorrenteRepository.GetContasCorrentes();
        }

    }
}

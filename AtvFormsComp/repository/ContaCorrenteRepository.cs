using AtvFormsComp.model;
using System.Collections.Generic;

namespace AtvFormsComp.repository
{
    class ContaCorrenteRepository
    {
        public static List<ContaCorrente> contaCorrenteList = new List<ContaCorrente>();

        public static ContaCorrente addContaCorrente(ContaCorrente contaCorrente)
        {
            contaCorrenteList.Add(contaCorrente);
            return contaCorrente;
        }

        public static List<ContaCorrente> GetContasCorrentes()
        {
            return contaCorrenteList;
        }

    }
}

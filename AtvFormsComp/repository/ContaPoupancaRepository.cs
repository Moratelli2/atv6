using AtvFormsComp.model;
using System.Collections.Generic;

namespace AtvFormsComp.repository
{
    class ContaPoupancaRepository
    {
        public static List<ContaPoupanca> contaPoupancaList = new List<ContaPoupanca>();

        public static ContaPoupanca addContaPoupanca(ContaPoupanca contaPoupanca)
        {
            contaPoupancaList.Add(contaPoupanca);
            return contaPoupanca;
        }

        public static List<ContaPoupanca> getContasPoupanca()
        {
            return contaPoupancaList;
        }

    }
}

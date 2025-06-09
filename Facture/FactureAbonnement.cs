using System;
using FactureNamespace;

namespace FactureAbonnementNamespace
{
    public class FactureAbonnement : Facture
    {
        public FactureAbonnement(long Numero, String type, decimal montantHt) : base(Numero, type, montantHt)
        {

        }


        public override decimal CalculerMontantTTC()
        {
            return MontantHt * 1.10m;
        }
    }
}

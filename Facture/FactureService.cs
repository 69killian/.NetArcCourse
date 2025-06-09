using System;
using FactureNamespace;

namespace FactureServiceNamespace
{
    class FactureService : FactureNamespace.Facture
    {
        public FactureService(long Numero, String type, decimal montantHt) : base(Numero, type, montantHt)
        {

        }

        public override decimal CalculerMontantTTC()
        {
            return MontantHt * 1.20m;
        }
    }
}
using System;
using FactureNamespace;

namespace FactureProduitNamespace
{
    public class FactureProduit : Facture
    {
        public FactureProduit(long Numero, String type, decimal montantHt) : base(Numero, type, montantHt)
        {

        }

        public override decimal CalculerMontantTTC()
        {
            return MontantHt * 1.05m;
        }
    }
    
}

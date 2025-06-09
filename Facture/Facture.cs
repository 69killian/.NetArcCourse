using System;
using FactureAbonnementNamespace;
using FactureProduitNamespace;
using FactureServiceNamespace;

namespace FactureNamespace
{
    public class Facture
    {
        public long Numero;
        public decimal MontantHt;
        public String Type;

        public Facture(long numero, String type,  decimal montantHt)
        {
            this.Numero = numero;
            this.Type = type;
            this.MontantHt = montantHt;
        }

        public virtual decimal CalculerMontantTTC()
        {
            return MontantHt * 1.2m;
        }

        public override string ToString()
        {
            return $"Facture #{Numero} \nType: {Type} \nMontant HT: {MontantHt}";
        }
        
    }
}

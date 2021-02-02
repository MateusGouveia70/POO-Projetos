using System.Globalization;


namespace ProductExercicio.Entities
{
    class ImportedProduct : Product
    {
        public double CustomeFree { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customeFree) : base(name, price)
        {
            CustomeFree = customeFree;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs free: {CustomeFree.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double TotalPrice()
        {
            return Price + CustomeFree;
        }
    }
}

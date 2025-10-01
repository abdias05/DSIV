namespace Laboratorio8._8
{
    class ClaseConcreta1 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcreta1";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcreta1";
        }
    }
}

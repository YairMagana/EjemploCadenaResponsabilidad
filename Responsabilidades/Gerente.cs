namespace EjemploCadenaResponsabilidad
{
    public class Gerente : AbstractAprobador
    {
        public override string DecidirAprobacion(decimal monto)
        {
            if (monto <= 10000)
                return $"Compra de Aires Acondicionados \"AUTORIZADA\" por el gerente";
            else
                return base.DecidirAprobacion(monto);
        }
    }
}

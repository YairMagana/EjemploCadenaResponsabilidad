namespace EjemploCadenaResponsabilidad
{
    public class Coordinador : AbstractAprobador
    {
        public override string DecidirAprobacion(decimal monto)
        {
            if (monto <= 5000)
                return $"Compra de Aires Acondicionados \"AUTORIZADA\" por el coordinador";
            else
                return base.DecidirAprobacion(monto);
        }
    }
}

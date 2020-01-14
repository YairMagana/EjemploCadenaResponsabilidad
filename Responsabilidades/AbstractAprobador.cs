namespace EjemploCadenaResponsabilidad
{
    public abstract class AbstractAprobador : IAutorizador
    {
        private IAutorizador autorizador;

        public virtual string DecidirAprobacion(decimal monto)
        {
            if (autorizador != null)
                return autorizador.DecidirAprobacion(monto);
            else
                return null;
        }

        public IAutorizador SiguientePosibleAutorizador(IAutorizador autorizador)
        {
            this.autorizador = autorizador;
            return autorizador;
        }
    }
}

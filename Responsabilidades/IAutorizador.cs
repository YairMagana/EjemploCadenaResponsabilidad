namespace EjemploCadenaResponsabilidad
{
    public interface IAutorizador
    {
        IAutorizador SiguientePosibleAutorizador(IAutorizador autorizador);

        string DecidirAprobacion(decimal monto);
    }
}

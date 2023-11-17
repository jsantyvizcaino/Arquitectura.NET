namespace Servicio.Application.Constants
{
    public static class MensajesGlobales
    {
        public const string ErroresPrecondiciones = "Existieron errores de precondiciones.";
        public const string ErroresValidacionesInternas = "Existieron errores de validaciones internas.";
        public const string ErroresNoControlados = "Existieron errores internos.";
        public const string ErroresInfraestructura = "Existieron errores de infraestructura.";

        public const string NoExisteEntidad = "No existe la entidad especifica buscada.";
        public const string IniciaConsulta = "Proceso de consulta iniciado: {0}.";
        public const string FinalizaConsulta = "Proceso de consulta finalizado: {0}.";
        public const string NoExistenDatos = "No existen datos para consulta realizada: {0}.";


        public const string IniciaComando = "Proceso de creación/actualización iniciado: {0}.";
        public const string FinalizaComando = "Proceso de creación/actualización finalizado: {0}.";
        public const string ErrorComando = "Error en la ejecución del comando ejecutado: {0}.";

        public const string EjecucionValidadores = "Comienza la ejecución del validador del comando: {0}.";
        public const string NoErroresValidadores = "No existen errores de precondiciones en el comando: {0}.";
        public const string ErroresValidadores = "Existen errores de precondiciones en el comando: {0}.";
    }
}

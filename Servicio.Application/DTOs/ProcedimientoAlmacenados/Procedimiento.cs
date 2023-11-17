using System.Globalization;

namespace Servicio.Application.DTOs.ProcedimientoAlmacenados
{
    public static class Procedimiento
    {
        public static FormattableString Ejecutar(string nombreProcedimiento, List<Parametro> parametros)
        {
            if (!parametros.Any())
            {
                return $"{nombreProcedimiento}";
            }

            return $"{nombreProcedimiento} {string.Join(',', parametros.Select(t => $"'{t.Valor}'"))}";
        }

        public static FormattableString EjecutarReporte(string nombreProcedimiento, List<Parametro> parametros)
        {
            if (!parametros.Any())
            {
                return $"{nombreProcedimiento}";
            }

            FormattableString respuesta = $"{nombreProcedimiento} {string.Join(',', parametros.Select(t => $"{(t.Valor is null ? "NULL" : (IsNumeric(t.Valor) ? t.Valor : "'" + t.Valor + "'"))}"))}";
            return respuesta;
        }

        public static FormattableString EjecutarReportePs(string nombreProcedimiento, List<Parametro> parametros)
        {
            if (!parametros.Any())
            {
                return $"{nombreProcedimiento}";
            }

            FormattableString respuesta = $"{nombreProcedimiento} {string.Join(',', parametros.Select(t => $"{(t.Valor is null ? "NULL" : "'" + t.Valor + "'")}"))}";
            return respuesta;
        }


        public static FormattableString EjecutarFuncion(string nombreProcedimiento, List<Parametro> parametros)
        {
            if (!parametros.Any())
            {
                return $"{nombreProcedimiento}";
            }

            return $"SELECT * FROM {nombreProcedimiento} ({string.Join(',', parametros.Select(t => $"{t.Valor}"))})";
        }

        public static FormattableString Ejecutar(string nombreProcedimiento)
        {

            return $"{nombreProcedimiento}";


        }


        public static bool IsNumeric(object expression)
        {
            if (expression == null)
                return false;

            double number;
            return Double.TryParse(Convert.ToString(expression
                                                    , CultureInfo.InvariantCulture)
                                  , System.Globalization.NumberStyles.Any
                                  , NumberFormatInfo.InvariantInfo
                                  , out number);
        }
    }
}
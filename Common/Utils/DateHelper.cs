namespace Common.Utils;

public static class DateHelper
{
    public static string ObterDataAtualFormatada() => DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
}
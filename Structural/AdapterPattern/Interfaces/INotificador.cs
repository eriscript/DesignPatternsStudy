namespace AdapterPattern.Interfaces;

public interface INotificador
{
    void Enviar(string destino, string mensagem);
}
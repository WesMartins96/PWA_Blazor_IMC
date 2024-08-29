using Imc.Models;

namespace Imc
{
    public static class AppState
    {
        //lista de calculos de imc
        public static List<ImcModel> History { get; set; } = new();

        //manipulação de eventos
        public static event EventHandler<EventArgs> OnChanged;


        //evento para notificar um histórico novo
        public static void NotifyChanges(object? sender, EventArgs args)
        {
            OnChanged.Invoke(sender, args);
        }

    }
}

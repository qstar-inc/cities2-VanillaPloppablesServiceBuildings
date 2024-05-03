using Colossal.Logging;
using Game;
using Game.Modding;

namespace StarQ_Vanilla_Ploppable_Service_Buildings
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"{nameof(StarQ_Vanilla_Ploppable_Service_Buildings)}.{nameof(Mod)}").SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info($"Current mod asset at {nameof(StarQ_Vanilla_Ploppable_Service_Buildings)}");
        }

        public void OnDispose()
        {
        }
    }
}

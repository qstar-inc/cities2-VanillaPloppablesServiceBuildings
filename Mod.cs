//using Colossal.Logging;
using Game;
using Game.Modding;

namespace VanillaPloppableServiceBuildings
{
    public class Mod : IMod
    {
        //public static ILog log = LogManager.GetLogger($"{nameof(VanillaPloppableServiceBuildings)}.{nameof(Mod)}").SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            //log.Info($"Current mod asset at {nameof(VanillaPloppableServiceBuildings)}");
        }

        public void OnDispose()
        {
        }
    }
}

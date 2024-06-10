using CommandPatherner.Comando;
using CommandPatherner.Receptores;
namespace CommandPatherner.Comando_Concreto
{
    public class TurnOnLightCommand : ICommand
    {
        private Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}

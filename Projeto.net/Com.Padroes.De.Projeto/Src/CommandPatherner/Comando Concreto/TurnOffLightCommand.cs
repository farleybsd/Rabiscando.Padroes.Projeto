﻿using CommandPatherner.Comando;
using CommandPatherner.Receptores;
namespace CommandPatherner.Comando_Concreto
{
    public class TurnOffLightCommand : ICommand
    {
        private Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}

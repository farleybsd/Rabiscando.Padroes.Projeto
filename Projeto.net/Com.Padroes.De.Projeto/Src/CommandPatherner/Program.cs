using CommandPatherner.Comando;
using CommandPatherner.Comando_Concreto;
using CommandPatherner.Invocador;
using CommandPatherner.Receptores;

Light light = new Light();
ICommand turnOn = new TurnOnLightCommand(light);
ICommand turnOff = new TurnOffLightCommand(light);

RemoteControl remote = new RemoteControl();

// Liga a luz
remote.SetCommand(turnOn);
remote.PressButton();

// Desliga a luz
remote.SetCommand(turnOff);
remote.PressButton();
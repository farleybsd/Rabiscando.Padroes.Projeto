//Vamos criar um canal de envios de E-MAIL
using Com.Padroes.De.Projeto.Bridge.Canais_de_envio;
using Com.Padroes.De.Projeto.Bridge.Dominio;

var canalEnvio = new Email();
//Vamos enviar uma mensagem de um administrador, definindo assunto e a mensagem
var mensagem = new MensagemAdmin(canalEnvio);
mensagem.setAssunto("Primeira mensagem");
mensagem.setMensagem("Olá Usuário");
mensagem.Enviar();

//Vamos enviar uma mensagem de um usuário, definindo assunto e a mensagem
var mensagemUsuarioEmail = new MensagemUsuario(canalEnvio);

mensagemUsuarioEmail.setAssunto("Primeira mensagem");
mensagemUsuarioEmail.setMensagem("Olá Administrador");
mensagemUsuarioEmail.Enviar();
//Agora vamos criar um canal de envios de SMS
var canalEnvioSMS = new SMS();
//Vamos enviar uma mensagem de um administrador, definindo assunto e a mensagem
mensagem = new MensagemAdmin(canalEnvioSMS);
mensagem.setAssunto("Segunda mensagem");
mensagem.setMensagem("Olá Usuário");
mensagem.Enviar();

//Vamos enviar uma mensagem de um usuário, definindo assunto e a mensagem
var mensagemUsuario = new MensagemUsuario(canalEnvioSMS);
mensagemUsuario.setAssunto("Segunda mensagem");
mensagemUsuario.setMensagem("Olá Administrador");
mensagemUsuario.Enviar();
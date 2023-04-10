using Xunit;

namespace InfrastructureTests
{
    public class ChatGPTTests
    {
        [Fact]
        public void GenerateDialogue_ReturnsCorrectDialogue()
        {
            //Arrange
            string completionText = @"Persona 1: �Hola! �Has estado afuera hoy? �El clima es incre�ble!\n\nPersona 2: �Incre�ble? Yo dir�a que es horrible. Ha estado lloviendo todo el d�a.\n\nPersona 1: Bueno, s�, pero eso es lo que lo hace incre�ble. Siempre estoy feliz cuando llueve, especialmente en d�as como hoy.\n\nPersona 2: De acuerdo, no puedo discutir contigo sobre eso. Pero, �qu� hay de la temperatura? Hace mucho fr�o para m�.\n\nPersona 1: S�, tienes raz�n. Pero muy bien se siente muy c�modo si te vistes adecuadamente. Siempre llevo mi abrigo y mis guantes en d�as como este.\n\nPersona 2: Ah, s�, eso tiene sentido. Y creo que esto es mejor que un d�a demasiado caluroso. Pero espero que el clima mejore pronto, estoy listo para algo de sol y calor.\n\nPersona 1: Totalmente estoy de acuerdo contigo. Pero mientras tanto, empezamos a disfrutar de la lluvia y el fr�o. �Quieres tomar una taza de t� caliente y hablar m�s sobre el clima? \n\nPersona 2: �Por supuesto! Eso suena genial.";



            //Act

            //Assert
        }
    }
}
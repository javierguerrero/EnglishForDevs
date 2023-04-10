using Xunit;

namespace InfrastructureTests
{
    public class ChatGPTTests
    {
        [Fact]
        public void GenerateDialogue_ReturnsCorrectDialogue()
        {
            //Arrange
            string completionText = @"Persona 1: ¡Hola! ¿Has estado afuera hoy? ¡El clima es increíble!\n\nPersona 2: ¿Increíble? Yo diría que es horrible. Ha estado lloviendo todo el día.\n\nPersona 1: Bueno, sí, pero eso es lo que lo hace increíble. Siempre estoy feliz cuando llueve, especialmente en días como hoy.\n\nPersona 2: De acuerdo, no puedo discutir contigo sobre eso. Pero, ¿qué hay de la temperatura? Hace mucho frío para mí.\n\nPersona 1: Sí, tienes razón. Pero muy bien se siente muy cómodo si te vistes adecuadamente. Siempre llevo mi abrigo y mis guantes en días como este.\n\nPersona 2: Ah, sí, eso tiene sentido. Y creo que esto es mejor que un día demasiado caluroso. Pero espero que el clima mejore pronto, estoy listo para algo de sol y calor.\n\nPersona 1: Totalmente estoy de acuerdo contigo. Pero mientras tanto, empezamos a disfrutar de la lluvia y el frío. ¿Quieres tomar una taza de té caliente y hablar más sobre el clima? \n\nPersona 2: ¡Por supuesto! Eso suena genial.";



            //Act

            //Assert
        }
    }
}
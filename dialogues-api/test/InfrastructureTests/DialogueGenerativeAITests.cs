using Domain.Entities;
using Infrastructure.GenerativeAI;
using Moq;
using Xunit;

namespace InfrastructureTests
{

    /// <summary>
    /// Convenci�n para los nombres: NombreDelM�todo_QueDeber�aDevolver_Condiciones()
    ///     Sumar_ShouldBe5_IfA3AndB2()
    ///     Par_ShouldBeTrue_IfA2()
    ///     Dividir_ShouldBe4_IfA8AndB2
    ///     Dividir_ShouldThrowDivideByZeroException_IfA8AndB0()
    /// </summary>

    public class DialogueGenerativeAITests
    {
        [Fact]
        public async Task GenerateDialogue_ReturnsDialogueWithEightInterventions()
        {
            //Arrange
            var mock = new Mock<IChatbot>(MockBehavior.Strict);
            mock.Setup(chatbot => chatbot.GenerateResponse()).ReturnsAsync("Persona 1: �Hola! �Has estado afuera hoy? �El clima es incre�ble!\\n\\nPersona 2: �Incre�ble? Yo dir�a que es horrible. Ha estado lloviendo todo el d�a.\\n\\nPersona 1: Bueno, s�, pero eso es lo que lo hace incre�ble. Siempre estoy feliz cuando llueve, especialmente en d�as como hoy.\\n\\nPersona 2: De acuerdo, no puedo discutir contigo sobre eso. Pero, �qu� hay de la temperatura? Hace mucho fr�o para m�.\\n\\nPersona 1: S�, tienes raz�n. Pero muy bien se siente muy c�modo si te vistes adecuadamente. Siempre llevo mi abrigo y mis guantes en d�as como este.\\n\\nPersona 2: Ah, s�, eso tiene sentido. Y creo que esto es mejor que un d�a demasiado caluroso. Pero espero que el clima mejore pronto, estoy listo para algo de sol y calor.\\n\\nPersona 1: Totalmente estoy de acuerdo contigo. Pero mientras tanto, empezamos a disfrutar de la lluvia y el fr�o. �Quieres tomar una taza de t� caliente y hablar m�s sobre el clima? \\n\\nPersona 2: �Por supuesto! Eso suena genial.");
            var DialogueGenerativeAI = new DialogueGenerativeAI(mock.Object);

            //Act
            var result = await DialogueGenerativeAI.GenerateDialogue();

            //Assert
            Assert.Equal(8, result.Turns.Count);
        }

        [Fact]
        public async Task CreateDialogue_CreatesDialogueWithExpectedParticipants_ValidInput()
        {
            //Arrange
            var participant1 = "Persona 1";
            var participant2 = "Persona 2";
            var expectedParticipants = new List<string> { participant1, participant2 };


            var mock = new Mock<IChatbot>(MockBehavior.Strict);
            mock.Setup(chatbot => chatbot.GenerateResponse()).ReturnsAsync("Persona 1: �Hola! �Has estado afuera hoy? �El clima es incre�ble!\\n\\nPersona 2: �Incre�ble? Yo dir�a que es horrible. Ha estado lloviendo todo el d�a.\\n\\nPersona 1: Bueno, s�, pero eso es lo que lo hace incre�ble. Siempre estoy feliz cuando llueve, especialmente en d�as como hoy.\\n\\nPersona 2: De acuerdo, no puedo discutir contigo sobre eso. Pero, �qu� hay de la temperatura? Hace mucho fr�o para m�.\\n\\nPersona 1: S�, tienes raz�n. Pero muy bien se siente muy c�modo si te vistes adecuadamente. Siempre llevo mi abrigo y mis guantes en d�as como este.\\n\\nPersona 2: Ah, s�, eso tiene sentido. Y creo que esto es mejor que un d�a demasiado caluroso. Pero espero que el clima mejore pronto, estoy listo para algo de sol y calor.\\n\\nPersona 1: Totalmente estoy de acuerdo contigo. Pero mientras tanto, empezamos a disfrutar de la lluvia y el fr�o. �Quieres tomar una taza de t� caliente y hablar m�s sobre el clima? \\n\\nPersona 2: �Por supuesto! Eso suena genial.");
            var DialogueGenerativeAI = new DialogueGenerativeAI(mock.Object);

            //Act
            var dialogue = await DialogueGenerativeAI.GenerateDialogue();

            //Assert
            //Assert.Equal(expectedParticipants, dialogue.Participants);
        }





        /*
            CreateDialogue_ValidInput_CreatesDialogueObject
            CreateDialogue_NullInput_ThrowsArgumentNullException
            CreateDialogue_EmptyParticipants_ThrowsArgumentException
            CreateDialogue_InvalidParticipants_ThrowsArgumentException
            CreateDialogue_ValidInput_CreatesDialogueWithExpectedId
            CreateDialogue_ValidInput_CreatesDialogueWithExpectedParticipants
            AddTurn_ValidInput_AddsTurnToDialogue
            AddTurn_NullInput_ThrowsArgumentNullException
            AddTurn_InvalidTurn_ThrowsArgumentException
            AddTurn_ValidInput_IncrementsTurnsCount
            GetDialogueLength_ValidInput_ReturnsExpectedLength
            GetDialogueLength_EmptyDialogue_ReturnsZero
            GetDialogueLength_NullInput_ThrowsArgumentNullException         
         
         */



















    }
}
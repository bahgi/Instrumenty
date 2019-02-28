using System.ComponentModel.DataAnnotations;
using Instrumenty;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class OrkiestraTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Teardown()
        {
        }

        [Test]
        public void UnitTest_WhenOrchestraPlays_ThenAllInstrumentsShouldPlay()
        {
            // Arrange
            var gitaraMock = new Mock<IGitara>();
            var skrzypceMock = new Mock<ISkrzypce>();
            var pianinoMock = new Mock<IPianino>();

            // Wstrzykiwanie zależności
            var orkiestra = new Orkiestra(gitaraMock.Object, pianinoMock.Object, skrzypceMock.Object);

            // Act
            orkiestra.PlayAllInstrument();

            // Assert
            gitaraMock.Verify(gitara => gitara.Play(), Times.Once);
            skrzypceMock.Verify(skrzypce => skrzypce.Play(), Times.Once);
            pianinoMock.Verify(pianino => pianino.Play(), Times.Once);
        }

        [Test]
        public void IntegrationTest_WhenOrchestraPlays_ThenAllInstrumentsShouldPlay()
        {
            // Arrange
            var gitara = new Gitara('c');
            var skrzypce = new Skrzypce('d');
            var pianino = new Pianino('e');

            // Wstrzykiwanie zależności
            var orkiestra = new Orkiestra(gitara, pianino, skrzypce);

            var oczekiwanaMelodia = "cdefde";

            // Act
            orkiestra.PlayAllInstrument();

            // Assert
            Assert.AreEqual(oczekiwanaMelodia, orkiestra.Melodia);
        }

        
    }
}
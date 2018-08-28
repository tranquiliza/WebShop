using Moq;
using System.Collections.Generic;
using System.Linq;
using WebShop.Controllers;
using WebShop.Models;
using WebShop.Models.Language;
using WebShop.Services.Abstractions;
using Xunit;

namespace WebShop.Test.Controllers
{
    public class LabelControllerShould
    {
        [Fact]
        public async void Return_Label_LabelAliasDtos()
        {
            //Arrange
            var service = CreateServiceWithLabels();
            var controller = new LabelController(service);

            //Act
            var result = await controller.GetLabels();

            //Assert
            var firstValue = result.First();

            Assert.NotEmpty(result);
            Assert.True(firstValue.LabelValues.Count() == 2);
        }

        [Fact]
        public async void Return_Label_LanguageLabelDtos()
        {
            //Arrange
            var service = CreateServiceWithLabels();
            var controller = new LabelController(service);

            //Act
            var result = await controller.GetLabels("da-DK");

            //Assert
            var firstValue = result.First();

            Assert.NotEmpty(result);
            Assert.Equal("Label Number: 0", firstValue.Alias);
            Assert.Equal("Værdi for 0 på dansk", firstValue.Value);
        }

        private ILabelService CreateServiceWithLabels()
        {
            var valuesToReturn = new List<Label>();

            var danish = new Language("Danish", "da-DK");
            typeof(Entity).GetProperty(nameof(Entity.Id)).SetValue(danish, 1);
            var english = new Language("English", "en-GB");
            typeof(Entity).GetProperty(nameof(Entity.Id)).SetValue(english, 2);

            for (int i = 0; i < 100; i++)
            {
                var label = new Label($"Label Number: {i}");

                var danishValue = new LabelValue($"Værdi for {i} på dansk", danish);
                var englishValue = new LabelValue($"Value for {i} in english", english);
                label.AddLabelValue(danishValue);
                label.AddLabelValue(englishValue);

                valuesToReturn.Add(label);
            }

            var mock = new Mock<ILabelService>();
            mock.Setup(x => x.Get()).ReturnsAsync(valuesToReturn);
            return mock.Object;
        }
    }
}

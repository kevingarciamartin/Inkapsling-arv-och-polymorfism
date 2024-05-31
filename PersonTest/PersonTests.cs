using Inkapsling__arv_och_polymorfism.Inkapsling;
using System;

namespace Inkapsling__arv_och_polymorfism.Inkapsling.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Age_Throw_ArgumentException()
        {
            // Arrange
            PersonHandler personHandler = new();

            uint age = 0;

            // Act
            Action act = () => personHandler.CreatePerson(age, "First", "Last", 1.70, 70);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void FirstName_Null_Throw_ArgumentException()
        {
            PersonHandler personHandler = new();

            Action act = () => personHandler.CreatePerson(10, null!, "Last", 1.70, 70);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }
        
        [Fact]
        public void FirstName_TooShort_Throw_ArgumentException()
        {
            PersonHandler personHandler = new();

            string firstName = "";

            Action act = () => personHandler.CreatePerson(10, firstName, "Last", 1.70, 70);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }
        
        [Fact]
        public void FirstName_TooLong_Throw_ArgumentException()
        {
            PersonHandler personHandler = new();

            string firstName = "These are supposed to be multiple first names";

            Action act = () => personHandler.CreatePerson(10, firstName, "Last", 1.70, 70);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void LastName_Null_Throw_ArgumentException()
        {
            PersonHandler personHandler = new();

            Action act = () => personHandler.CreatePerson(10, "First", null!, 1.70, 70);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void LastName_TooShort_Throw_ArgumentException()
        {
            PersonHandler personHandler = new();

            string lastName = "";

            Action act = () => personHandler.CreatePerson(10, "First", lastName, 1.70, 70);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }
        
        [Fact]
        public void LastName_TooLong_Throw_ArgumentException()
        {
            PersonHandler personHandler = new();

            string lastName = "These are supposed to be multiple first names";

            Action act = () => personHandler.CreatePerson(10, "First", lastName, 1.70, 70);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
        }
    }
}
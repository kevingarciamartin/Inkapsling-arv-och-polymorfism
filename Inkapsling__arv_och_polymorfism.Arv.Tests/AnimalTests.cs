namespace Inkapsling__arv_och_polymorfism.Arv.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void Bird_Stats_ReturnExpectedString()
        {
            double weight = 1.0;
            double speed = 1.0;
            bool isWarmBlooded = true;
            bool layEggs = true;

            Bird bird = new(weight, speed, isWarmBlooded, layEggs);

            string expected = $"Weight: {weight}, " +
                $"Speed: {speed}, " +
                $"IsWarmBlooded: {isWarmBlooded}, " +
                $"LayEggs: {layEggs}, " +
                $"Characteristic: {bird.Characteristic}";

            Assert.Equal(expected, bird.Stats());
        }

        [Fact]
        public void Flamingo_Stats_ReturnExpectedString()
        {
            double weight = 1.0;
            double speed = 1.0;
            bool isWarmBlooded = true;
            bool layEggs = true;

            Flamingo flamingo = new(weight, speed, isWarmBlooded, layEggs);

            string expected = $"Weight: {weight}, " +
                $"Speed: {speed}, " +
                $"IsWarmBlooded: {isWarmBlooded}, " +
                $"LayEggs: {layEggs}, " +
                $"Characteristic: {flamingo.Characteristic}, " +
                $"Family: {flamingo.Family}";

            Assert.Equal(expected, flamingo.Stats());
        }

        [Fact]
        public void Wolfman_Stats_ReturnExpectedString()
        {
            double weight = 1.0;
            double speed = 1.0;
            bool isWarmBlooded = true;
            bool layEggs = false;

            Wolfman wolfman = new(weight, speed, isWarmBlooded, layEggs);

            string expected = $"Weight: {weight}, " +
                $"Speed: {speed}, " +
                $"IsWarmBlooded: {isWarmBlooded}, " +
                $"LayEggs: {layEggs}, " +
                $"Characteristic: {wolfman.Characteristic}";

            Assert.Equal(expected, wolfman.Stats());
        }
    }
}
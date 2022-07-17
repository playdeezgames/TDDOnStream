using EverCraftCs;
using Shouldly;
using Xunit;

namespace EverCraft.CsTests
{
    public class CharacterTests
    {
        [Fact]
        public void ShouldHaveAName()
        {
            const string Name = "Name";
            var subject = new Character
            {
                Name = Name
            };
            subject.Name.ShouldBe(Name);
        }
        [Theory]
        [InlineData(Alignment.Good)]
        [InlineData(Alignment.Neutral)]
        [InlineData(Alignment.Evil)]
        public void ShouldHaveAnAlignment(Alignment alignment)
        {
            var subject = new Character
            {
                Alignment = alignment
            };
            subject.Alignment.ShouldBe(alignment);
        }
        [Fact]
        public void ShouldHaveArmorClassOf10ByDefault()
        {
            var subject = new Character();
            subject.ArmorClass.ShouldBe(10);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void ShouldAllowArmorClassToBeSet(int newArmorClass)
        {
            var subject = new Character
            {
                ArmorClass = newArmorClass
            };
            subject.ArmorClass.ShouldBe(newArmorClass);
        }
    }
}
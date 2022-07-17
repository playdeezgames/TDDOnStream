namespace EverCraftCs
{
    public class Character
    {
        public Character()
        {
            ArmorClass = 10;
        }
        public string? Name 
        {
            get;
            set;
        }
        public Alignment Alignment 
        {
            get;
            set;
        }
        public int ArmorClass
        {
            get;
            set;
        }
    }
}

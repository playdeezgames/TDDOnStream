namespace EverCraftCs
{
    public class Character
    {
        public Character()
        {
            ArmorClass = 10;
            HitPoints = 5;
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
        public int HitPoints
        {
            get;
            set;
        }

        public bool Attack(Character defender, int attackRoll)
        {
            return attackRoll >= defender.ArmorClass;
        }
    }
}

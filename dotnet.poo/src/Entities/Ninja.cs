namespace dotnet.poo.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public string Attack(int Bonus)
        {
            if ((Bonus > 1 && Bonus < 6))
            {
                return this.Name + 
                " Executou um ataque mortal com bonus de " + Bonus; 
            } else if (Bonus > 6 && Bonus <= 10)
            {
                return this.Name + " Executou um fatality com bonus de " + Bonus;
            } else
            {
                return this.Name + " Ataque fraco com Shuriken " + Bonus;
            }
        }
    }
}
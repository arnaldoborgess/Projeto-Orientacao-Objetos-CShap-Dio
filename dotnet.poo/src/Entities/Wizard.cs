namespace dotnet.poo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        
        public string Attack(int Bonus)
        {
            if(Bonus > 1 && Bonus < 6)
            {
                return this.Name + " Lançou Magia de nível: " + Bonus;
            } else if (Bonus > 6 && Bonus <= 10)
            {
                return this.Name + " Lançou Magia efetiva com bonus nível " + Bonus;
            } else 
            {
                return this.Name + " Lançou uma força fraca com bonus nível " + Bonus;
            }
        }
    }    
}
namespace dotnet.poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus)
        {
            if ((Bonus > 1 && Bonus < 6))
            {
                return this.Name + " Executou ataque de espada " + Bonus;
            }
            else if (Bonus > 6 && Bonus <= 10)
            {
                return this.Name + " Executou ataque de força bruta " + Bonus;
            }
            else
            {
                return this.Name + " Executou um ataque fraco do escudo " + Bonus;
            }
        }    
    }      
}

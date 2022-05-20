namespace dotnet.poo.src.Entities
{
    public abstract class Hero
    {
        public Hero(String Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
            {
                return this.Name + " " + this.Level + " " + this.HeroType;
            }

            public virtual string Attack(int Bonus){
                if (Bonus > 1 && Bonus < 6)
            {
                return this.Name + " Executou ataque de espada " + Bonus;
            } else if (Bonus > 6 && Bonus <= 10)
            {
                return this.Name + " Executou ataque espada de força bruta " + Bonus;
            } else
            {
                return this.Name + " Executou um ataque fraco do espada " + Bonus;
            }
        }
    }
}
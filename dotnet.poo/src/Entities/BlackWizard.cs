namespace dotnet.poo.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public string Attack(int Bonus)
        {
            if (Bonus > 1 && Bonus < 6)
            {
                return this.Name + " Lançou um ataque de invocação do guerreiro das trevas " + Bonus;
            } else if (Bonus > 6 && Bonus <= 10)
            {
                return this.Name + " Lançou um ataque de chamas de dragão infernal " + Bonus;
            } else
            {
                return this.Name + " Lançou um ataque fraco do Mago Negro " + Bonus;
            }
        }
    }
}
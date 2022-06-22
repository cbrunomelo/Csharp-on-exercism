using System;


namespace Wizards_and_Warriorss
{

    public class Warriors : Character, IAtacar
    {

        // public delegate void WarriorAttackedHandler(object source, EventArgs args);

        // public event WarriorAttackedHandler? WarriorAttaked;

        public event EventHandler? WarriorAttaked;


        protected virtual void OnWarriorAttaked(EventArgs e)
        {
            if (WarriorAttaked != null)
            {
                EventHandler handler = WarriorAttaked;
                handler.Invoke(this, EventArgs.Empty);
            }
        }




        public Warriors(string name) : base(name)
        {

            MaxHit = 10;
            MinHit = 6;

        }

        public void DamagePoints(Character persona)
        {

            Console.WriteLine("Damege deal " + (persona.Vuneravel ? $"{MaxHit}" : $"{MinHit}"));
            OnWarriorAttaked(EventArgs.Empty);

        }


    }

    public class Wizards : Character, IAtacar
    {



        public void PrepareSpell()
        {
            Vuneravel = false;
            Console.WriteLine("Preparando magia");
        }

        public void DamagePoints(Character persona) => Console.WriteLine("Damage deal " + (Vuneravel ? $"{MinHit}" : $"{MaxHit}"));



        public Wizards(string name) : base(name)
        {
            MaxHit = 12;
            MinHit = 3;
            Vuneravel = true;

        }

        public void OnWarriorAttaked(object? sender, EventArgs e) => PrepareSpell();


    }



    public class Character
    {
        public int MaxHit { get; set; }
        public int MinHit { get; set; }
        public bool Vuneravel { get; set; }
        public string Name { get; set; }


        public Character(string name)
        {

            Name = name;
            Vuneravel = false;
        }

        public override string ToString() => $"O personagem e {Name} um {GetType().Name} ";



    }

    public interface IAtacar
    {
        void DamagePoints(Character persona);
    }
}

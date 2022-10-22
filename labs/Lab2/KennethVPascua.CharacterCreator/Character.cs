/*
 Kenneth V. Pascua
 Lab 2
 ITSE 1430, Fall 2022
 */

namespace KennethPascua.CharacterCreator
{
   public class Character
    {
        public Character () : this("", "")
        {
        
        }
        public Character (string name ) : this (name,"")
        {

        }

        public Character (string name, string description ) : base()
        {
            Name = name;
            Description = description;
        }
        public int Id { get; private set; }
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value?.Trim() ?? ""; }
        }
        private string _name;
        public string Class
        {
                get { return _class ?? ""; }
                set { _class = value?.Trim() ?? ""; }
        }
        private string _class;
        public string Race
            {
                get { return _race ?? ""; }
                set { _race = value?.Trim() ?? ""; }
            }
        private string _race;
        
        public string Description
            {
                get { return _description ?? ""; }
                set { _description = value?.Trim() ?? ""; }
            }
        private string _description;
        
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }

        public Character Clone ()
        {
            var character = new Character();
            CopyTo(character);

            return character;
        }

        public void CopyTo ( Character character )
        {
            character.Name = Name;
            character.Class = Class;
            character.Race = Race;
            character.Description = Description;
            character.Strength = Strength;
            character.Intelligence = Intelligence;
            character.Agility = Agility;
            character.Constitution = Constitution;
            character.Charisma = Charisma;
        }
    } 
}



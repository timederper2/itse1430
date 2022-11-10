using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennethPascua.CharacterCreator
{
    public class Character
    {
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

        public int Strength {get; set;}
        public int Intelligence {get; set;}
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }

        public const int MinimumAllowedAttribute = 1;
        public const int MaximumAllowedAttribute = 100;




    }
}

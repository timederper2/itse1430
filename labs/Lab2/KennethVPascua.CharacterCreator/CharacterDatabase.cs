using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Kenneth V. Pascua
 Lab 2
 ITSE 1430, Fall 2022
 */

namespace KennethPascua.CharacterCreator
{
    public class CharacterDatabase
    {
        public virtual Character Add ( Character character )
        {
            _character = character;
            return character;
        }

        public Character Get ( int id )
        {
            if (_character != null && _character.Id == id)
                return _character;

            return null;
        }

        private Character _character;
    }
}

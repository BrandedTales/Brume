using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    public class Hero : Piece
    {
        public GameData_HeroList heroList;

        public void InitializeHero(HeroContent newHero)
        {
            isDeployed = true;
            this.name = newHero.name;
            artwork = newHero.artwork;
            flavor = newHero.flavor;

            heroList.Add(this);
        }
    }
}
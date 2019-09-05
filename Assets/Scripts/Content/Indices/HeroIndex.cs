using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Indices/Hero Index")]
    public class HeroIndex : ScriptableObject
    {
        public List<HeroContent> heroContentList;

        public HeroContent RandomHero()
        {
            HeroContent randomHero = null;

            if (heroContentList.Count > 0)
            {
                randomHero = heroContentList[Random.Range(0, heroContentList.Count)];
                heroContentList.Remove(randomHero);
            }

            return randomHero;
        }
    }
}
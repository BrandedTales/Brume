using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    public class Land : MonoBehaviour
    {
        public bool isActive;

        public ArtworkVariable artwork;
        public FlavorVariable flavor;

        public void InitializeLand(LandContent newLand)
        {
            isActive = false;
            this.name = newLand.name;
            artwork = newLand.artwork;
            flavor = newLand.flavor;
        }


    }
}
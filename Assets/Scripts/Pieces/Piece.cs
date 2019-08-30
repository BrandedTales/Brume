using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    public abstract class Piece : MonoBehaviour
    {
        public ArtworkVariable artwork;
        public FlavorVariable flavor;

        public Land location;

        public bool isDeployed;


    }
}
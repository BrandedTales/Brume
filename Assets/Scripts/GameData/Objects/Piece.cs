using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BT.Brume
{
    public abstract class Piece : ScriptableObject
    {
        public StringVariable flavor;

        public bool isActive;

        public SpriteVariable cardPortrait;
        public SpriteVariable token;

        public List<GameProperty> gameProperties;

        public GameAction leftClick;


    }
}
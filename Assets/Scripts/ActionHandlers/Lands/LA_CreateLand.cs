using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Actions/CreateLand")]
    public class LA_CreateLand : LandAction
    {
        [SerializeField] BoardReference gdBoard;
        [SerializeField] WorldContent world;


        public override void Invoke(Land curLand)
        {
            if (curLand != null) Debug.Log("Do we initialize?");
            curLand.InitializeLand(world.RandomLand());
            curLand.transform.SetParent(GameObject.FindGameObjectWithTag("LandPanel").transform, false);

        }
    }
}
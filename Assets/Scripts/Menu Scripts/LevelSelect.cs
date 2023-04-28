using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSelect
{
    public class LevelSelect : MonoBehaviour
    {
        public void LoadLevel1()
        {
            Utilities.LoadLevel(1);
        }
        public void LoadLevel2()
        {
            Utilities.LoadLevel(2);
        }
        public void LoadLevel3()
        {
            Utilities.LoadLevel(3);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        public void StartGame()
        {
            Utilities.NextLevel();
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
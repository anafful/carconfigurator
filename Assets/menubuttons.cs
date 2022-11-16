using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menubuttons : MonoBehaviour
{
    public GameObject Menupanel;
    public GameObject MainMenupanel;

    public void OpenMenu()
    {
        if (Menupanel != null)
        {
            Menupanel.SetActive(true);
            MainMenupanel.SetActive(false);
        }



    }

    public void CloseMenu()
    {
        Menupanel.SetActive(false);
        MainMenupanel.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class menubuttons : MonoBehaviour
{
    public GameObject Menupanel;
    public GameObject MainMenupanel;
    [SerializeField] GameObject[] CarCameras;

    private int CurrentCamera;



    private void Update()
    {
       
    }


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


    public void CameraSwitch()
    {
        CurrentCamera = 0;

        for(int i = 0; i < CarCameras.Length; i++)
        {
            CarCameras[i].gameObject.SetActive(false);
            Debug.Log("switch camera");
        }
        //if(CarCameras.Length > 0)
        {
          //  CarCameras[0].gameObject.SetActive(true);
        }

        //Cinecameraloop();
    }

     public void Cinecameraloop()
    {
        if (CarCameras.Length != 0)
        {
            foreach (GameObject camera in CarCameras)
            {
                camera.GetComponent<CinemachineVirtualCamera>().Priority = Random.Range(10, 8);
            }
        }
    }
     

}

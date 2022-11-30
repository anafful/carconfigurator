using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraCinemachine : MonoBehaviour
{
    [SerializeField] GameObject[] CarCameras = new GameObject[4];
    //[SerializeField] int[] CarcamerasID = new int[] { 0, 1, 2, 3};
    private int currentcam = 0;
  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
              if (currentcam == CarCameras.Length)
                 
                    
                currentcam = 0;
               
                else
                    currentcam++;
           
            for (int i = 0; i < CarCameras.Length; i++)
            {
                //Carcameras = 0;
                if (i == currentcam) CarCameras[i].SetActive(true);
               // Debug.Log(CarCameras[i]);
                //Debug.Log(CarcamerasID[i]);

                else CarCameras[i].SetActive(false);    
                //CarCameras[i].SetActive(false);





            }

        }
            
            
          

            }
            
        }
    



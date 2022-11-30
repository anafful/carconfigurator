using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraCinemachine : MonoBehaviour
{
    [SerializeField] GameObject[] CarCameras = new GameObject[4];
    [SerializeField] int[] CarcamerasID = new int[] { 0, 1, 2, 3};
  
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < CarcamerasID.Length; i++)
            {
             

                Debug.Log(CarCameras[i]);
                Debug.Log(CarcamerasID[i]);

                //CarCameras[i].SetActive(false);
                
                if (CarcamerasID[i] == 0)
                    {
                    CarCameras[i].SetActive(false);
                    }

               
            }

            }
            
        }
    }



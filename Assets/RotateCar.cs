using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCar : MonoBehaviour
{

    public float RotationSpeed = 2f;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * RotationSpeed;

        transform.Rotate(Vector3.down, XaxisRotation);
    }
}

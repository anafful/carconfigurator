using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carclass : MonoBehaviour
{

    public Car cardata;


    public totalprice totalP;

    //text fields
    public Text carname;
    public Text CarbodyPrice;

    public Renderer CarRenderer;


    // Start is called before the first frame update
    void Start()
    {
        carname.text = cardata.name;
        //CarbodyPrice.text = cardata.CarPartPrice;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

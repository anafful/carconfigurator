using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Carscript : MonoBehaviour
{
    public totalprice totalP;

    //text fields
    public Text carcolour;
    public Text CarbodyPrice;






    //arrays

    public string[] CarColour = { "Yellow", "Blue", "Red" };
    public Renderer CarRenderer;
    public Material[] Carbodycolour;
    public int[] displaycarbodyprice = { 1000, 2000, 3000 };










    int currentItem = 0;
    //int totalprices = 0;

    // Start is called before the first frame update
    void Start()
    {


        carcolour.text = CarColour[currentItem];
        CarbodyPrice.text = displaycarbodyprice[currentItem].ToString();

        SetCarBodyMaterial();

        totalP.SetTotalPrice();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void NextSelection()
    {
        currentItem++;
        if (currentItem > CarColour.Length - 1)
        {
            currentItem = 0;
        }

        carcolour.text = CarColour[currentItem];
        CarbodyPrice.text = displaycarbodyprice[currentItem].ToString();

        SetCarBodyMaterial();
        //movecamera();

        totalP.SetTotalPrice();
    }

    public void BackSelection()
    {
        currentItem--;
        if (currentItem < 0)
        {
            currentItem = CarColour.Length - 1;
        }

        carcolour.text = CarColour[currentItem];
        CarbodyPrice.text = displaycarbodyprice[currentItem].ToString();

        SetCarBodyMaterial();
        //movecamera();

        totalP.SetTotalPrice();
    }

    private void SetCarBodyMaterial()
    {
        CarRenderer.material = Carbodycolour[currentItem];
    }

    public int GetPrice()
    {
        return displaycarbodyprice[currentItem];
    }

    //public void movecamera()
   // {
       // Camera.main.transform.Translate(1, 1, 1);

    //}
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carspoiler : MonoBehaviour
{

    public totalprice TotalCarprice;

    public Text CarspoilerPrice;
    public Text carspoilername;

    public String[] Carsspoiler = { "White", "Gold Plated", "Black Matted" };
    public Renderer CarSpoiler;
    public Material[] CarSpoilercolour = new Material[3];
    public int[] displaycarspoiler = { 200, 300, 300 };

    int currentItem = 0;

    // Start is called before the first frame update
    void Start()
    {

        carspoilername.text = Carsspoiler[currentItem];
        CarspoilerPrice.text = displaycarspoiler[currentItem].ToString();

        SetCarSpoilerMaterial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NextSelection()
    {
        currentItem++;
        if (currentItem > Carsspoiler.Length - 1)
        {
            currentItem = 0;
        }

        carspoilername.text = Carsspoiler[currentItem];
        CarspoilerPrice.text = displaycarspoiler[currentItem].ToString();

        SetCarSpoilerMaterial();

        TotalCarprice.SetTotalPrice();
    }

    public void BackSelection()
    {
        currentItem--;
        if (currentItem < 0)
        {
            currentItem = Carsspoiler.Length - 1;
        }


        carspoilername.text = Carsspoiler[currentItem];
        CarspoilerPrice.text = displaycarspoiler[currentItem].ToString();

        SetCarSpoilerMaterial();

        TotalCarprice.SetTotalPrice();
    }

    private void SetCarSpoilerMaterial()
    {
        CarSpoiler.material = CarSpoilercolour[currentItem];
    }

    public int GetPrice()
    {
        return displaycarspoiler[currentItem];
    }
}

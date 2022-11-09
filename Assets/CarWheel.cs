using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarWheel : MonoBehaviour
{
    public totalprice TotalCarprice;

    public Text CarWheelsPrice;
    public Text carswheelname;

    public String[] Carswheel = { "Rogue", "Eco Friendly", "Blue Sky" };
    public Renderer[] CarWheels;
    public Material[] CarWheelscolour;
    public int[] displaycarwheelsprice = { 300, 1000, 600 };

    int currentItem = 0;

    // Start is called before the first frame update
    void Start()
    {

        carswheelname.text = Carswheel[currentItem];
        CarWheelsPrice.text = displaycarwheelsprice[currentItem].ToString();

        SetCarWheelsMaterial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextSelection()
    {
        currentItem++;
        if (currentItem > Carswheel.Length - 1)
        {
            currentItem = 0;
        }



        carswheelname.text = Carswheel[currentItem];
        CarWheelsPrice.text = displaycarwheelsprice[currentItem].ToString();

        SetCarWheelsMaterial();

        TotalCarprice.SetTotalPrice();
    }

    public void BackSelection()
    {
        currentItem--;
        if (currentItem < 0)
        {
            currentItem = Carswheel.Length - 1;
        }

        carswheelname.text = Carswheel[currentItem];
       
        CarWheelsPrice.text = displaycarwheelsprice[currentItem].ToString();

        SetCarWheelsMaterial();

        TotalCarprice.SetTotalPrice();
    }

    private void SetCarWheelsMaterial()
    {
        for(int i = 0; i < CarWheels.Length; i++)
        {
            CarWheels[i].material = CarWheelscolour[currentItem];
        }
    }

    public int GetPrice()
    {
        return displaycarwheelsprice[currentItem];
    }
}

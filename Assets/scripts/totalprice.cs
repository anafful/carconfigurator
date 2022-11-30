using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalprice : MonoBehaviour
{
    public Carscript carscript;
    public Carspoiler carspoiler;
    public CarWheel carWheel;


    [SerializeField] private Text totalPriceText;


    public void SetTotalPrice()
    {
        totalPriceText.text = (carscript.GetPrice() + carspoiler.GetPrice() + carWheel.GetPrice()).ToString();
    }
}



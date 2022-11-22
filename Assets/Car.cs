using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CarPart", menuName ="Cars")]
public class Car : ScriptableObject
{

    
    public GameObject totalP;


    public GameObject Name;
    public int CarPartPrice;

    public GameObject[] CarModel;
    public string[] CarOptions;
    public Material[] ColourChange;
    public int[] CarPrice;


   
}

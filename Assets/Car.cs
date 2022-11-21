using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CarPart", menuName ="Cars")]
public class Car : ScriptableObject
{
    public totalprice totalP;

    public Text Name;
    public Text CarPartPrice;


    public string[] CarOptions;
    public Renderer CarRenderer;
    public Material[] ColourChange;
    public int[] CarPrice;
}

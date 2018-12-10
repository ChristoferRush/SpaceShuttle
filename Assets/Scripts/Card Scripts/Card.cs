using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public int cost;
    public int firePower;
    public int defence;
    public string description;

}

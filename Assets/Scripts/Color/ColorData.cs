using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ColorData
{
    [SerializeField] private string _name;
    public string Name => _name;
    [SerializeField] private Color _color;
    public Color MaterialColor => _color;


}

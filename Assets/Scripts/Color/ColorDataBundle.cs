
using UnityEngine;

[CreateAssetMenu(fileName = "New ColorsData", menuName = "Colors Data", order = 10)]
public class ColorDataBundle : ScriptableObject
{
    [SerializeField] private ColorData[] _colorsData;
    [SerializeField] public enum A { }
    public ColorData[] ColorsData => _colorsData;
}
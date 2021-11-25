using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
    private static readonly List<Color> _colors = new List<Color>();
    [SerializeField] private ColorDataBundle _dataBundle;
    private static int _rightColorId;
    private static int _wrongColorId;
    private bool isInitialized = false;

    private void Start()
    {
        if (!isInitialized)
        {
            Initialize();
        }
    }
    private void Initialize()
    {
        for (int i = 0; i < _dataBundle.ColorsData.Length; i++)
        {
            _colors.Add(_dataBundle.ColorsData[i].MaterialColor);
        }
        isInitialized = true;
    }
    public static Color GetColorFromStatus(StageColorType colorType)
    {
        switch (colorType)
        {
            case StageColorType.Right: return _colors[_rightColorId];
            case StageColorType.Wrong: return _colors[_wrongColorId];
            default: return new Color(0, 0, 0);
        }
    }
    public void RandomizeColorsId()
    {
        if (isInitialized)
        {
            _rightColorId = Random.Range(0, _dataBundle.ColorsData.Length);
            while (true)
            {
                int temp = Random.Range(0, _dataBundle.ColorsData.Length);
                if (temp != _rightColorId)
                {
                    _wrongColorId = temp;
                    break;
                }
            }
        }
    }
}

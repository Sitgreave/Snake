using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
    private static readonly List<Color> _colors = new List<Color>();
    [SerializeField] private ColorDataBundle _dataBundle;
    private static int _rightColorId;
    private static int _wrongColorId;
    private static int _lastRightId;
    private bool isInitialized = false;

    private void Awake()
    {
        if (!isInitialized)
        {
            Initialize();
            RandomizeColorsId();
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
    public static Color LastRightColor()
    {
        return _colors[_lastRightId];
    }
    public void WriteLastRightId()
    {
        _lastRightId = _rightColorId;
    }
    public void RandomizeColorsId()
    {
        if (isInitialized)
        {
            WriteLastRightId();
            int temp;
            while (true)
            {
                int j = 0;

                temp = Random.Range(0, _dataBundle.ColorsData.Length);
                if (temp != _lastRightId)
                {
                    _rightColorId = temp;
                    break;
                }
                j++;
                if (j == 100) break;
            }
            while (true)
            {
                int j = 0;
                temp = Random.Range(0, _dataBundle.ColorsData.Length);
                if (temp != _rightColorId)
                {
                    _wrongColorId = temp;
                    break;
                }
                j++;
                if (j == 100) break;
            }
        }
    }
}

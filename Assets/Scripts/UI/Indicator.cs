using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Indicator : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private ChainSpawner _spawner;
    [SerializeField] private Image _barImage;
    [SerializeField] private Image _iconImage;
    [SerializeField] TMP_Text _healthCountText;
    private Color _defaultColor;


    private void Start()
    {
        _defaultColor = _barImage.color;
        UpdateBar();
    }
    public void UpdateBar()
    {
        float currentValue = _spawner.CurrentCount + 1;
        float maxValue = _spawner.Count + 1;
        _healthBar.value = currentValue / maxValue;
        _healthCountText.text = currentValue.ToString() + "\\" + maxValue.ToString();
    }
    public void SwitchBarColor()
    {
        _barImage.color = Color.yellow;
        _iconImage.color = Color.yellow;
        Invoke("SetDefaultColor", _spawner.FeverTime);
    }

    public void SetDefaultColor()
    {
        _barImage.color = _defaultColor;
        _iconImage.color = _defaultColor;
    }
}

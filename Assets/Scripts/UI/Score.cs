using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private TMP_Text _streakText;
    [SerializeField] private Wallet _wallet;
    private void OnEnable()
    {
        _wallet.OnCoinsChanged += SetCoinsText;
        _wallet.OnCrystalsChanged += SetStreakText;
    }
    private void OnDisable()
    {
        _wallet.OnCoinsChanged -= SetCoinsText;
        _wallet.OnCrystalsChanged -= SetStreakText;
    }
    public void SetCoinsText()
    {
        _coinsText.text = _wallet.Coins.ToString();
    }
    public void SetStreakText()
    {
    
        _streakText.text = _wallet.Crystal.ToString() + "\\3";
    }

    
}

using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private TMP_Text _streakText;
    [SerializeField] private Wallet _wallet;
    [SerializeField] private MoveText _moveTextPrefab;
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
        SpawnMoveMoneyText();
    }
    public void SetStreakText()
    {
        _streakText.text = _wallet.Crystal.ToString() + "\\3";
        SpawnMoveCrystalText();
    }

    public void SpawnMoveMoneyText()
    {
        MoveText newText = Instantiate(_moveTextPrefab, transform);
        newText._target = _coinsText.transform;
        newText._value = "+" + _wallet.IncreaseValueCoins;
    }   
    public void SpawnMoveCrystalText()
    {
        MoveText newText = Instantiate(_moveTextPrefab, transform);
        newText._target = _streakText.transform;
        newText._value = "+" + _wallet.IncreaseValueCrystal;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _coins;
    public int Coins => _coins;

    private int _crystal;
    public int Crystal => _crystal;

    
    public delegate void WalletHandler();
    public event WalletHandler OnCoinsChanged;
    public event WalletHandler OnCrystalsChanged;
    private int _increaseValueCoins;
    private int _increaseValueCrystal;
    public int IncreaseValueCoins => _increaseValueCoins;
    public int IncreaseValueCrystal => _increaseValueCrystal;
    public void AddCoins(int count)
    {
        if(count > 0)
        {
            _coins += count;
            _increaseValueCoins = count;
            OnCoinsChanged.Invoke();
        }
    }

    public void AddCrystal(int count)
    {
        if (count > 0)
        {
            if (_crystal < 2)
            {
                _crystal += count;
            }
            else
            {
                _crystal = 0;
                SnakeEvents.OnFeverActivated.Invoke();
            }
            _increaseValueCrystal = count;
            OnCrystalsChanged.Invoke();
        }
    }
}

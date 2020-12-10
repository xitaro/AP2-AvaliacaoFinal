using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    [SerializeField] public TMP_Text textMoney;
    
    private int money;

    private void Awake()
    {
        money = PlayerPrefs.GetInt("money");
        textMoney.SetText(money.ToString());
    }

    public void SetMoney(int _money)
    {
        money += _money;
        textMoney.SetText(money.ToString());
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.Save();
    }

    public int GetMoney()
    {
        return money;
    }

    public void BuyStuff(int value)
    {
        money -= value;
        textMoney.SetText(money.ToString());
        PlayerPrefs.SetInt("money",money);
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        money = 0;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.Save();
    }
}

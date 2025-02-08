using UnityEngine;
using TMPro;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText, _coinsTextTwo, _coinsTextThree;
    private int _coins;

    private void Start()
    {
        _coins = PlayerPrefs.GetInt("MyCoins", 0);
        TableText();
    }

    public void ResetCoins()
    {
        PlayerPrefs.DeleteKey("MyCoins");
        _coins = 0;
        TableText();
    }

    public void AddCoin()
    {
        _coins++;
        PlayerPrefs.SetInt("MyCoins", _coins);
        TableText();
    }

    private void TableText()
    {
        _coinsText.text = ($"{_coins}");
        _coinsTextTwo.text = ($"{_coins}/10");
        _coinsTextThree.text = ($"{_coins}/52");
    }
}
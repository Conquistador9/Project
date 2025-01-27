using UnityEngine;
using TMPro;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    private int _coins;

    private void Start()
    {
        TableText();
    }

    public void AddCoin()
    {
        _coins++;
        _coinsText.text = _coins.ToString();
        TableText();
    }

    private void TableText() => _coinsText.text = ($"{_coins}");
}
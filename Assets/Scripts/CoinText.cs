using UnityEngine;
using TMPro;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private TMP_Text _coinsTextTwo;
    private int _coins;

    private void Start()
    {
        TableText();
    }

    private void Update()
    {
        CollectedCoins();
    }

    public void AddCoin()
    {
        _coins++;
        _coinsText.text = _coins.ToString();
        TableText();
    }

    private void TableText() => _coinsText.text = ($"{_coins}");

    private void CollectedCoins() => _coinsTextTwo.text = ($"{_coins}/10");
}
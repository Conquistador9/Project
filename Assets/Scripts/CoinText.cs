using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText, _coinsTextTwo, _coinsTextThree, _coinsTextTwoComplected, _coinsTextThreeComplected;
    private int _levelOneScene = 1, _levelTwoScene = 2;
    private int _coins, _levelOneCoins, _levelTwoCoins;

    private void Start()
    {
        LoadData();
        TotalCoins();
        TableText();
    }

    public void ResetCoins()
    {
        PlayerPrefs.DeleteAll();
        _coins = 0;
        _levelOneCoins = 0;
        _levelTwoCoins = 0;
        TableText();
    }

    public void RestCoinsLevelTwo()
    {
        PlayerPrefs.DeleteKey("LevelTwoCoins");
        _levelTwoCoins = 0;
        TableText();
    }

    public void AddCoin()
    {
        SceneCheck();
        SaveData();
        TotalCoins();
        TableText();
    }

    private void TotalCoins() => _coins = _levelOneCoins + _levelTwoCoins;

    private void TableText()
    {
        _coinsText.text = ($"{_coins}/52");
        _coinsTextTwo.text = ($"{_levelOneCoins}");      
        _coinsTextTwoComplected.text = ($"{_levelOneCoins}/10");
        _coinsTextThree.text = ($"{_levelTwoCoins}");     
        _coinsTextThreeComplected.text = ($"{_levelTwoCoins}/42");
    }

    private void SaveData()
    {
        PlayerPrefs.SetInt("LevelOneCoins", _levelOneCoins);
        PlayerPrefs.SetInt("LevelTwoCoins", _levelTwoCoins);
        PlayerPrefs.Save();
    }

    private void LoadData()
    {
        _levelOneCoins = PlayerPrefs.GetInt("LevelOneCoins", 0);
        _levelTwoCoins = PlayerPrefs.GetInt("LevelTwoCoins", 0);
    }

    private void SceneCheck()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene == _levelOneScene) _levelOneCoins++;
        else if (currentScene == _levelTwoScene) _levelTwoCoins++;
    }
}
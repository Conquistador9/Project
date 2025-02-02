using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Animator _animator;
    [SerializeField] private InputTouch _inputTouch;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _timerTextObject;
    [SerializeField] private TMP_Text _timerText;

    [Header("Timer")]
    [SerializeField] private float _maxTimer;
    private GameObject _player;
    private float _timer;
    private bool _isTimer= false;

    private void Start()
    {
        _timer = _maxTimer;
        FindPlayer();
    }

    private void Update()
    {
        FindPlayer();
        GameProcess();
        TimerView();
        GameOverScreen();
    }

    private void GameOverScreen()
    {
        if (!_isTimer)
        {
            _gameOverPanel.SetActive(true);
            _timerTextObject.SetActive(false);
            _inputTouch.enabled = false;
            _inputTouch.Decelerate();
        }
    }

    private void FindPlayer() => _player = GameObject.FindGameObjectWithTag("Player");

    private void GameProcess()
    {
        if (_player)
        {
            _isTimer = true;
            _timer -= Time.deltaTime;
            TimerColor();

            if (_timer <= 0f)
            {
                TimerFalse();
                _timer = 0f;
            }
        }
        else TimerFalse();
    }

    private void TimerFalse() => _isTimer = false;

    private void TimerView() => _timerText.text = Mathf.Round(_timer).ToString();

    private void TimerColor()
    {
        if (_timer <= 10f)
        {
            _timerText.color = Color.red;
            _animator.enabled = true;
        }
        else _timerText.color = Color.green;
    }
}
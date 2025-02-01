using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputTouch _inputTouch;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private float _maxTimer;
    [SerializeField] private float _timer;
    [SerializeField] private bool _isTimer= false;
    private GameObject _player;

    private void Start()
    {
        _timer = _maxTimer;
        FindPlayer();
    }

    private void Update()
    {
        if (_player)
        {
            _isTimer = true;
            Debug.Log("lol");
            _timer -= Time.deltaTime;
            TimerColor();

            if(_timer <= 0f)
            {
                _isTimer = false;
                _timer = 0f;
                Debug.Log("kek");
            }
        }
        else
        {
            _isTimer = false;
            Debug.Log("UMER");
        }

        FindPlayer();
        TimerView();
        GameOverScreen();
    }

    private void GameOverScreen()
    {
        if (!_isTimer)
        {
            _gameOverPanel.SetActive(true);
            _inputTouch.enabled = false;
            _inputTouch.Decelerate();
        }
    }

    private void FindPlayer() => _player = GameObject.FindGameObjectWithTag("Player");

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
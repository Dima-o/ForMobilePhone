using UnityEngine;
using UnityEngine.UI;

public class SettingTimer : MonoBehaviour
{
    [SerializeField] Text textTimer;
    [SerializeField] GameObject menuDefeat;
    [SerializeField] float givenTimer;

    [SerializeField] private bool activeTimer;
    private float timer;

    private void Start()
    {
        Time.timeScale = 1;
        textTimer.text = givenTimer.ToString();
        activeTimer = true;
        timer = givenTimer;
    }

    private void Update()
    {
        if (activeTimer)
        {
            Timer();
        }
    }

    private void Timer()
    {
        timer -= Time.deltaTime;
        textTimer.text = timer.ToString("F0");

        if (timer <= 0)
        {
            StopTimer();
        }
    }

    private void StopTimer()
    {
        activeTimer = false;
        textTimer.text = "0";
        menuDefeat.SetActive(true);
        Time.timeScale = 0;
    }
}

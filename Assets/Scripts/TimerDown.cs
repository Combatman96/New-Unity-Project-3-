using UnityEngine;
using UnityEngine.UI;

public class TimerDown : MonoBehaviour
{
    public Text timeLabel;
    // Update is called once per frame
    void Update()
    {
        int j = (int)(PlayerModel.timeRemaining);
        timeLabel.text = j.ToString();
    }
}

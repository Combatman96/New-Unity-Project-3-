using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public GameObject endPanel;
    public Text winState;

    // Update is called once per frame
    void Update()
    {
        if(PlayerModel.score == 10)
        {
            Win();
        }
        else if (PlayerModel.timeRemaining == 0)
        {
            Lose();
        }
    }

    private void Win()
    {
        endPanel.SetActive(true);
        winState.text = "YOU WON";
    }

    private void Lose()
    {
        endPanel.SetActive(true);
        winState.text = "YOU LOSE";
    }
}

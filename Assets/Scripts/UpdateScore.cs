using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    public Text scoreLable;
    // Update is called once per frame
    void Update()
    {
        int playerScore = PlayerModel.score;
        scoreLable.text = playerScore.ToString();
    }
}

using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public static int score = 0;
    public static float timeRemaining = 14f;

    public static void IncreateScore()
    {
        score += 5;
    }

    private void Update()
    {
        timeRemaining -= Time.deltaTime;
        //Debug.Log(timeRemaining);
        if (timeRemaining <= 0)
        {
            timeRemaining = 0;
        }
    }
}

using UnityEngine;

public class Onclick : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        PlayerModel.IncreateScore();
    }
}

using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (Player.position.z + 7).ToString("0");
    }
}

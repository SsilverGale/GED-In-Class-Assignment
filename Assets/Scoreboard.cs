using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public Text scoreBoard;

    // Update is called once per frame
    void Update()
    {
        scoreBoard.text = GameManager.Instance.getScore().ToString();
    }
}

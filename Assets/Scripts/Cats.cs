using UnityEditor;
using UnityEngine;

public class Cats : MonoBehaviour
{
    public int speed = 10;
    private GameManager _gamemanager = GameManager.Instance;
    private void OnEnable()
    {
        _gamemanager.pause += Pause;
        _gamemanager.unpause += unPause;
    }
    private void Pause()
    {
        speed = 0;
    }
    private void unPause()
    {
        speed = 10;
    }
    void Update()
    {
        transform.Translate(0, 0, -speed*Time.deltaTime);
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}

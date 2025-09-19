using UnityEngine;

public class Player : MonoBehaviour
{
    public int key;
    void Start()
    {
        GameManager.Instance.generateNewKey();
        key = GameManager.Instance.getKey();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) && (key == 0))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && (key == 1))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && (key == 2))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && (key == 3))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && (key == 4))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) && (key == 5))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) && (key == 6))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) && (key == 7))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) && (key == 8))
        {
            newKey();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) && (key == 9))
        {
            newKey();
        }
    }

    private void newKey()
    {
            GameManager.Instance.spawnCat();
            GameManager.Instance.addScore(1);
            GameManager.Instance.generateNewKey();
            key = GameManager.Instance.getKey();
    }
}

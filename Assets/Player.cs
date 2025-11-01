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
        switch (key)
        {
            case 0:

                if (Input.GetKeyDown(KeyCode.Alpha0))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 1:

                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 2:

                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 3:

                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 4:

                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 5:

                if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 6:

                if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 7:

                if (Input.GetKeyDown(KeyCode.Alpha7))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 8:

                if (Input.GetKeyDown(KeyCode.Alpha8))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
            case 9:

                if (Input.GetKeyDown(KeyCode.Alpha9))
                {
                    correctKey();
                }
                else if(Input.anyKeyDown)
                {
                    incorrectKey();
                }
                break;
        }
        

    }

    private void correctKey()
    {
        GameManager.Instance.spawnCat();
        GameManager.Instance.addScore(1);
        GameManager.Instance.generateNewKey();
        key = GameManager.Instance.getKey();
    }
        private void incorrectKey()
    {
            GameManager.Instance.spawnAngyCat();
            GameManager.Instance.addScore(-1);
            GameManager.Instance.generateNewKey();
            key = GameManager.Instance.getKey();
    }
}

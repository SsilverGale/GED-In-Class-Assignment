using System;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Score;
    public int inputKey;
    [SerializeField] public GameObject cat;
    [SerializeField] public GameObject angyCat;
    Quaternion catRotation = Quaternion.Euler(270, 180, 0);

    public event Action pause;
    public event Action unpause;
    private bool paused = false;

    public void TogglePause()
    {
        if (paused == false)
        {
            pause?.Invoke();
            paused = true;
        } else {
            unpause?.Invoke();
            paused = false;
        }

    }
    //Base singleton setup
    private void Awake()
    {
        //Is there is another instance, then self destruct
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        //Otherwise this is the active instance
        else
        {
            Instance = this;
        }
    }

    //Increases Score by inputteed int
    public void addScore(int i)
    {
        Score += i;
    }

    //Spawns Cats
    public void spawnCat()
    {
        Instantiate(cat, new Vector3(UnityEngine.Random.Range(-5, 5), 5, UnityEngine.Random.Range(-5, 5)), catRotation);
    }
    public void spawnAngyCat()
    {
        Instantiate(angyCat, new Vector3(UnityEngine.Random.Range(-5, 5), 5, UnityEngine.Random.Range(-5, 5)), catRotation);
    }
    public int getScore()
    {
        return Score;
    }
    public void generateNewKey()
    {
        inputKey = UnityEngine.Random.Range(0, 10);
        UIManager.Instance.setNumberUI();
    }
    public int getKey()
    {
        return inputKey;
    }
    public void closeGame()
    {
        Application.Quit();
    }

}

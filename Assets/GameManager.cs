using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int Score;
    public int inputKey;
    [SerializeField] public GameObject cat;
    [SerializeField] public GameObject angyCat;
    Quaternion catRotation = Quaternion.Euler(270, 180, 0);

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
        Instantiate(cat, new Vector3(Random.Range(-5, 5), 5, Random.Range(-5, 5)), catRotation);
    }
    public void spawnAngyCat()
    {
        Instantiate(angyCat, new Vector3(Random.Range(-5, 5), 5, Random.Range(-5, 5)), catRotation);
    }
    public int getScore()
    {
        return Score;
    }
    public void generateNewKey()
    {
        inputKey = Random.Range(0, 9);
    }
    public int getKey()
    {
        return inputKey;
    }
}

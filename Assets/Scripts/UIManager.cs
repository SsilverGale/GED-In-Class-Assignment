using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager _gamemanager;
    [SerializeField] private Text scoreBoard;
    [SerializeField] private Text Guide;

    [SerializeField] Text pauseText;
    private bool paused;
    public static UIManager Instance { get; private set; }
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
        private void OnEnable()
    {
        _gamemanager.pause += Pause;
        _gamemanager.unpause += unPause;
    }
    private void Pause()
    {
        pauseText.text = ("Unpause");
        Guide.text = "Unpause to see number";
    }
    private void unPause()
    {
        pauseText.text = ("Pause");
        Guide.text = "Type the key : " + GameManager.Instance.getKey().ToString();
    }
    void Update()
    {
        scoreBoard.text = GameManager.Instance.getScore().ToString();
    }
    public void setNumberUI()
    {
        Guide.text = "Type the key : " + GameManager.Instance.getKey().ToString();
    }
}

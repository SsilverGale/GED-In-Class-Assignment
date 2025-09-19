using UnityEngine;
using UnityEngine.UI;

public class GuideText : MonoBehaviour
{
    public Text Guide;
    void Update()
    {
        Guide.text = "Type in: " + GameManager.Instance.getKey().ToString();
    }
}

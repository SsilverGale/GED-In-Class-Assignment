using UnityEngine;

public class Cats : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}

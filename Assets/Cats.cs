using UnityEngine;

public class Cats : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.y < -10f)
        {
            Destroy(this);
        }
    }
}

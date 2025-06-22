using UnityEngine;

public class ForceApplier : MonoBehaviour
{
    private BodyPhysics body;

    private void Start()
    {
        body = GetComponent<BodyPhysics>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Áp lực hướng lên khi nhấn Space
            body.AddForce(new Vector3(0, 200f, 0));
        }
    }
}

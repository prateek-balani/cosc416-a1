using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(Vector2.up);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(Vector2.down);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(Vector2.left);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(Vector2.right);
        }
    }
}

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
        Vector2 inputVector = Vector2.zero;

        if(Input.GetKeyDown(KeyCode.W))
        {
            inputVector += Vector2.up;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        Debug.Log("Resultant Vector: " + inputVector);
    }
}

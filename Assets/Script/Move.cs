using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    void Update()
    { 
        move();
    }

    void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, 1f) * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -1f) * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-1, 0f) * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(1, 0f) * speed * Time.deltaTime);
        }
    }
}

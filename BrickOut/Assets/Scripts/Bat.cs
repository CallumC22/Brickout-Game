using UnityEngine;

public class Bat : MonoBehaviour
{
    public float speed = 0.2f;
    float direction = 0.0f;
    public KeyCode moveLeftKey = KeyCode.LeftArrow;
    public KeyCode moveRightKey = KeyCode.RightArrow;
    bool canMoveLeft = true;
    bool canMoveRight = true;

    void FixedUpdate()
    {
        Vector3 position = transform.localPosition; 
        //this sets "vector3" position to "transform.localposition"
        position.x += speed * direction; 
        //this line sets the position on the x axis to = speed multiplied by direction
        transform.localPosition = position;
        //this line sets "transform.localposition" to the current position of the bat
    }

    void Update()
    {
        bool isLeftPressed = Input.GetKey(moveLeftKey);
        //this line checks to see if the left arrow key is currently being pressed
        bool isRightPressed = Input.GetKey(moveRightKey);
        //this line checks to see if the right arrow key is currently being pressed

        if (isLeftPressed && canMoveLeft)
        {
            direction = -1.0f;
            //when left arrow is pressed the bar moves left
        }

        else if (isRightPressed && canMoveRight)
        {
            direction = 1.0f;
            //when right arrow is pressed the bar moves right 
        }
        else
        {
            direction = 0.0f;
            //when nothing is pressed the bar doesnt move
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "Left Wall":
                canMoveLeft = false;
                break;
                //when touching the left wall the bat cant move left
            case "Right Wall":
                canMoveRight = false;
                break;
                //when touching the right wall the bat cant move right
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        switch (other.gameObject.name)
        {
            case "Left Wall":
                canMoveLeft = true;
                break;
                //when the bat stops touching the left wall it can move left
            case "Right Wall":
                canMoveRight = true;
                break;
                //when the bat stops touching the right wall it can move right
        }
    }
}


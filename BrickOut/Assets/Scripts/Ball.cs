using UnityEngine;

public class Ball : MonoBehaviour
{

    public float size = 1.0f;
    private float speed = 0.2f;
    float directionX = 1.0f;
    float directionY = 0.5f;
    
    
    void Start()
    {
        speed = 0.2f / size;  
        //this sets the speed to be equal to 0.2 divided by the size of the ball
    }

  
    void FixedUpdate()
    {
        Vector3 scale = new Vector3();
        //this line updates vector3 
        scale.x = 0.5f;
        //this sets the x scale to 0.2
        scale.y = 0.5f;
        //this sets the y variable to 0.5
        transform.localScale = scale;
        //this line makes the local scale to scale

        Vector3 position = transform.localPosition;
        //this sets "vector3" position to "transform.localposition"
        position.x += speed * directionX;
        //this line sets the position on the x axis to = speed multiplied by direction
        position.y += speed * directionY;
        //this line sets the position on the y axis to = speed multiplied by direction
        transform.localPosition = position;
        //this line sets "transform.localposition" to the current position of the ball
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        int count = 0;
        //setting count = 0 
            switch (other.gameObject.name)
            {
                case "Left Wall":
                case "Right Wall":
                    directionX = -directionX;
                    //when the ball collides withe the left or right wall the x axis direction is flipped
                    break;


                case "Brick 1":
                case "Brick 1 (1)":
                case "Brick 1 (2)":
                case "Brick 1 (3)":
                case "Brick 1 (4)":
                case "Brick 1 (5)":
                case "Brick 1 (6)":
                case "Brick 1 (7)":
                case "Brick 1 (8)":
                case "Brick 1 (9)":
                case "Brick 1 (10)":
                case "Brick 1 (11)":
                case "Brick 1 (12)":
                case "Brick 1 (13)":
                case "Brick 1 (14)":
                case "Brick 1 (15)":
                case "Brick 1 (16)":
                case "Brick 1 (17)":
                case "Brick 1 (18)":
                case "Brick 1 (19)":
                    directionY = -directionY;
                    count++;
                // incrimenting count by 1
                    break;
                //when the ball collides with any of the bricks the Y axis direction is flipped

                case "Top":
                case "Bat":
                    directionY = -directionY;

                    break;

                //when the ball collides with the Top wall or the Bat the y axis direction is flipped 
                case "Bottom Wall":
                    Destroy(gameObject);

                    break;
                    // when the ball interacts with the bottom wall(which is off screen) it is despawned
            }
        

       
    }
}


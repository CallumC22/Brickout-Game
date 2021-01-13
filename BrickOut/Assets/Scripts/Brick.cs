using UnityEngine;

public class Brick : MonoBehaviour
{
  

    void DespawnBrick(Brick bricktoDespawn)
    {
        Destroy(bricktoDespawn.gameObject);
        //this line destroys/despawns the brick
    }

    public void OnCollisionEnter2D(Collision2D other) 
    {
        switch (other.gameObject.name)
        {
            case "Ball(Clone)":
                DespawnBrick(this);
                //when the ball collides with the brick it calls "DespawnBrick" and runs it, which despawns the brick
               
             break;

        }

    }
}
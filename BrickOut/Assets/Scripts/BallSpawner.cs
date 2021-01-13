using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Ball Balltemplate;
    
    public void Start()
    {
       
       Ball ballClone =Instantiate(Balltemplate);
        // this line sets "ball clone" = to the ball template 
        ballClone.transform.position = transform.position; 
        //this line sets the clone ball's starting point to the spawners location
        ballClone.gameObject.SetActive(true);
        //this activates the ball clone
        
    }
}

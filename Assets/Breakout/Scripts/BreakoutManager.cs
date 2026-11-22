using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class BreakoutManager : MonoBehaviour
{
    //I use a static variable to make this accessible from anywhere
    //You can access this variable from anywhere by typing 'BreakoutManager.Me'
    //No need to capture the BreakoutManager in a variable name first, like you usually need
    public static BreakoutManager Me;
    //As a manager, I keep a link to all the major game elements
    public PaddleController Paddle;
    public BallController Ball;
    int n;
    int u;
    float movex;
    float movey;

    //The brick prefab
    public BrickController BrickPrefab;
    
    //I keep a list of all bricks that exist
    public List<BrickController> AllBricks;
    
    void Start()
    {
        //I need to register myself as 'the' BreakoutManager
        BreakoutManager.Me = this;

        //This is the code for spawning bricks. It's not very good.
        //How could we make this spawn lots of bricks more efficiently?
        for(n = 0; n < 10; n++) //use n here to make it run 10 times. ok wait whys it only running 9 times? I set n to 0, make it n<10 so shouldnt it run from 0-9 which is 10? oh nvm.counted wrong
        {
            movex = Random.Range(-5, 5); //just random range of x values
            movey = Random.Range(-5, 5); //the random range of y values
            Instantiate(BrickPrefab, new Vector3(movex, movey, 0), Quaternion.identity); //the code that spawns the brick at a random location
        }
        //for step 2 im not sure if your asking us to make 4 of the 10 bricks spawn on the same y level or just spawn 4 extra bricks on the same level. I'm assuming its the later.
        for(u = 0; u < 4; u++)
        {
            movex = Random.Range(-10, 10);
            movey = 4; //right yeah the code is the same except y isnt a random range now. its just y=4.
            Instantiate(BrickPrefab, new Vector3(movex,movey, 0), Quaternion.identity);
        }
    }

    void Update()
    {
        //Check to see if all the bricks have been broken
        if (AllBricks.Count == 0)
        {
            //If so, win
            //SceneManager.LoadScene("You Win");
        }
    }


    
}

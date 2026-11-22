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

        //for step 2 im not sure if your asking us to make 4 of the 10 bricks spawn on the same y level or just spawn 4 extra bricks on the same level. I'm assuming its the later. getting rid of step 1 stuf.
        for(u = 0; u < 5; u++)
        {
            movex = Random.Range(-5, 5);
            movey = 4; //right yeah the code is the same except y isnt a random range now. its just y=4.
            //ok this is goofy? I dont kow why it doesnt seem to be spawning 4 bricks. its only spawning 3? either that or the 4th is buried. chanign it to u < 5 instead of u < 4 fixed it. why.
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

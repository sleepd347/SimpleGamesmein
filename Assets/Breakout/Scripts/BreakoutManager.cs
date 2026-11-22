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

        //ok im chaning step 2's code for step 3 now.
            //ok -6.75 and 6.75 are the borders where the bricks touch wall. 6.75*2 is 13.5, 13.5/8 should be the 8 eight coords where i need to spawn a brick at? Set a list of x values for it to instantiate?
            List<float> xpositions = new List<float> { -6.75f, -4.75f, -2.75f, -0.75f, 1.25f, 3.25f, 5.25f, 7.25f}; //ok wait hold up. the spacing between each brick is 2. So I can't have a row of 8 bricks that fit inside the walls? is this a mistake in the assingment or do i gotta move the walls? ok i just moved the walls over.
            movey = 4; //right yeah the code is the same except y isnt a random range now. its just y=4.
            foreach (var x in xpositions)
            {
                Instantiate(BrickPrefab, new Vector3(x, movey, 0), Quaternion.identity); //ok yeah this works. Im spawning 8 bricks, no overlaps, same y level. its just the walls are still overlapping with the last brick.
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

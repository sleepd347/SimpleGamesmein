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

     

        //the last part is kind of the same as step 3, just working with y instead of x now.
            //ok -6.75 and 6.75 are the borders where the bricks touch wall. 6.75*2 is 13.5, 13.5/7 should be the 8 eight coords where i need to spawn a brick at? Set a list of x values for it to instantiate?
            List<float> ypositions = new List<float> { 4.5f, 4, 3.5f, 3,2.5f,2,}; //I'm guessing here on the spacing between each brick when it comes to their y level. I'm certain the spacing is 2 for x but y is a weird number. 0.5 is the closest i can estimate it to.
        foreach( var y in ypositions )
        {
            List<float> xpositions = new List<float> { -6.75f, -4.75f, -2.75f, -0.75f, 1.25f, 3.25f, 5.25f, 7.25f }; //ok wait hold up. the spacing between each brick is 2. So I can't have a row of 8 bricks that fit inside the walls? is this a mistake in the assingment or do i gotta move the walls? ok i just moved the walls over.
            foreach (var x in xpositions)
            {
                Instantiate(BrickPrefab, new Vector3(x, y, 0), Quaternion.identity);
            }
        }//ok yeah it works all good now.
        
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

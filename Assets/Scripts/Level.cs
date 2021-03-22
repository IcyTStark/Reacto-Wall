using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    //Inspector Parameters
    [SerializeField] int breakableBlock;
    public void CountBreakableBlocks()
    {
        breakableBlock++;
    }

    public void BlockDestroyed()
    {
        breakableBlock--;
        if (breakableBlock <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}

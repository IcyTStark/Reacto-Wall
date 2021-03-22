using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //Cached Reference
    Level level;
    [SerializeField] GameObject blockSparklesVFX;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        if (gameObject.tag == "Break")
        {
            level.CountBreakableBlocks();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "Break")
        {
            TriggerSparklesVFX();
            Destroy(gameObject);
            level.BlockDestroyed();
            FindObjectOfType<GameStatus>().AddScore();
            
        }
    }

    private void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(blockSparklesVFX,transform.position,transform.rotation);
        Destroy(sparkles, 5f);
    }



}

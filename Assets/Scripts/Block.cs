using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip breakSound;
    
    // cached reference
    Level level;
    //  GameSession gameSession;
    Score score;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        // gameSession = FindObjectOfType<GameSession>();
        score = FindObjectOfType<Score>();
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        // gameSession.AddToScore();
        score.increaseScore();
        Destroy(gameObject);
        level.BlockDestroyed();
    }
}

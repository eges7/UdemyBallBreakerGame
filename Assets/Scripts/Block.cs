﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip breakSound;
    
    // cached reference
    Level level;
    GameSession gameSession;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        gameSession = FindObjectOfType<GameSession>();
        level.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        gameSession.AddToScore();
        Destroy(gameObject);
        level.BlockDestroyed();
    }
}

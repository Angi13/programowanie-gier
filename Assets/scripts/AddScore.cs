using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private static int i = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreCounter.score++;
        if (++i % 5 == 0)
            Time.timeScale += 0.1F;
    }
}

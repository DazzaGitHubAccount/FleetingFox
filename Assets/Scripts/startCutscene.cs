using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    public static bool isCutsceneOn;
    public Animator camAnim;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isCutsceneOn = true;
            camAnim.SetBool("Cutscene 1", true);
            Invoke(nameof(StopCutScene), 2f);
        }
    }
    void StopCutScene()
    {
        isCutsceneOn = false;
        camAnim.SetBool("Cutscene 1", false);
    }
}




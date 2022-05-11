using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpTimes;
    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag != "Hit")
        {
            bumpTimes++;
            print($"You've bumped into {bumpTimes}  walls");
        }
        
    }
   
}

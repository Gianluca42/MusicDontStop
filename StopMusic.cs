using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(MusicDontStop.Instance != null)
       Destroy( MusicDontStop.Instance.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

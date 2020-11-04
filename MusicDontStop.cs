using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDontStop : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private static MusicDontStop instance = null;

    public static MusicDontStop Instance
    {
        get { return instance; }

    }
    private void Awake()
    {

        if (instance != null && instance != this)
        {

            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

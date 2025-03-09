using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneObject : MonoBehaviour

{
    private void Awake()
    {
        cursorlocker = CursorLocker.Instance;
    }
    CursorLocker cursorlocker;
    
    [SerializeField] public int lockstate = 1;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

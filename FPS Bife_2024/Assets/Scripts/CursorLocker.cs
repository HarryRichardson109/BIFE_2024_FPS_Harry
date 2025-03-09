using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLocker : MonoBehaviour
{
    public int lockstate; 
    public static CursorLocker Instance { get; private set; }
    private void Awake()
    {
        lockstate = 3;
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
      
    }

    public void Cursorupdate(int lockstate)
    {
        switch (lockstate)
        {
            case 0:
                Cursor.lockState = CursorLockMode.Locked; 
                Debug.Log ("0");
                break;
                
            case 1:
                Cursor.lockState = CursorLockMode.None;
                Debug.Log ("1");
                break;
            case 2:
                Cursor.lockState = CursorLockMode.Confined;
                Debug.Log ("2");
                break;

        }
    }
}

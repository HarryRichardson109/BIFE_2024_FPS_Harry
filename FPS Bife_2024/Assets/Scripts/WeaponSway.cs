using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
    

{
    [Header("swaysettings")]
    [SerializeField] private float smooth;
    [SerializeField] private float swaymultiplier;

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * swaymultiplier;
        float mouseY = Input.GetAxisRaw("Mouse Y") * swaymultiplier;

        Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
        Quaternion rotationY = Quaternion.AngleAxis(mouseX, Vector3.up);

        Quaternion targetRotation = rotationX * rotationY;

        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth *Time.deltaTime);


    }

}

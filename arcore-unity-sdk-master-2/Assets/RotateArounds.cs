using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateArounds : MonoBehaviour {

    public float speed = 1f;
    public GameObject ObjectToRotate;

    public void RotateMyObject()
    {
        float sliderValue = GetComponent<Slider>().value;
        ObjectToRotate.transform.rotation = Quaternion.Euler(sliderValue * 360, 0, 90);
    }
}

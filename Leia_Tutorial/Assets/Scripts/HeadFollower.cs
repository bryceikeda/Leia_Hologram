using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadFollower : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.eulerAngles = new Vector3(0f, Camera.main.transform.eulerAngles.y, 0f);
    }
}

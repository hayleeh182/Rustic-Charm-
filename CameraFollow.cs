using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform followTransform;

    [SerializeField] public int XOffset;
    [SerializeField] public int YOffset;
    [SerializeField] public int ZOffset;

    // Update is called once per frame
    void Update()
    {
      this.transform.position = new Vector3(followTransform.position.x + XOffset,
      followTransform.position.y + YOffset, this.transform.position.z + ZOffset);
    }
}

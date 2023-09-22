using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneComposition : MonoBehaviour
{
    public Transform firstSceneComposition;
    public Transform secondSceneComposition;
    public Transform thirdSceneComposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) == true)
        {
            gameObject.transform.position = firstSceneComposition.position;
            gameObject.transform.rotation = firstSceneComposition.rotation;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) == true)
        {
            gameObject.transform.position = secondSceneComposition.position;
            gameObject.transform.rotation = secondSceneComposition.rotation;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) == true)
        {
            gameObject.transform.position = thirdSceneComposition.position;
            gameObject.transform.rotation = thirdSceneComposition.rotation;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataClass {
    public int myInt;
    public float myFloat;
}

public class DemoScript : MonoBehaviour
{

    public Light myLight;
    public Light myOtherLight;
    public DataClass myClass;

    void Awake()
    {
        int myVar = AddTwo(9, 2);
        Debug.Log(myVar);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            MyFunction();
        }
    }

    /*
    Awake() Always called first, first frame of the game
    Start()  
    Update() Called once per frame
    FixedUpdate() When you want to do physics work (done at a regular pace rather than speed of rendering)
    LateUpdate() Called at the end of the frame, will look through all of the game objects and once it's done with the Update.
    Could be used to move camera last. Execution order of event functions
    */

    void MyFunction()
    {
        myLight.enabled = !myLight.enabled;

    }

    int AddTwo(int var1, int var2)
    {
        int returnValue = var1 + var2;
        return returnValue;
    }

}
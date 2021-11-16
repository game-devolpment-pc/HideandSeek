using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardSpawner: MonoBehaviour {
    [SerializeField] protected KeyCode keyToPress;
    [SerializeField] protected GameObject prefabToSpawn;
    [SerializeField] protected Vector3 velocityOfSpawnedObject;
    bool flag = true;
    [SerializeField] int live;

    protected virtual GameObject spawnObject() {
        // Step 1: spawn the new object.
        
        Vector3 positionOfSpawnedObject = transform.position;  // span at the containing object position.
        Quaternion rotationOfSpawnedObject = Quaternion.identity;  // no rotation.
        GameObject newObject = Instantiate(prefabToSpawn, positionOfSpawnedObject, rotationOfSpawnedObject);

        // Step 2: modify the velocity of the new object.
        

        return newObject;
    }
    void Start()
    {
           
    }
    
    private void Update() {
       if (Input.GetKeyDown(keyToPress)) {
           spawnObject();
           //live--;
          // if (live == 0){
            //Debug.Log("Game over!");
           // Application.Quit();
           // #if UNITY_EDITOR
           // UnityEditor.EditorApplication.isPlaying = false;
           // #endif
        //}
       }
    }
}

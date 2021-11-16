using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] int live;
    [SerializeField] protected KeyCode keyToPress;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled ) {
            live--;
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            
     
        }
    
    }

    private void Update() {
       // live--;
           // if (live == 1){
           // Debug.Log("Game over!");
           // Application.Quit();
           // #if UNITY_EDITOR
           // UnityEditor.EditorApplication.isPlaying = false;
           // #endif
       // }
        }
    
    }

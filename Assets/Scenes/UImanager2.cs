using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.UI;

public class UImanager : MonoBehaviour

{
    public GameObject ScrollArea;
    bool hehmahopen=false;
    // Start is called before the first frame update

   void Start() {
    ScrollArea.SetActive(false);
   }
    
    public void hehmah()
    {
        if(hehmahopen==false){ScrollArea.SetActive(true); 
        hehmahopen=true
        ;}
        else if(hehmahopen==true)
        {ScrollArea.SetActive(false);
        hehmahopen=false;}
        
        
    }
    

}

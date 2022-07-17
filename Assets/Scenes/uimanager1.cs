using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.UI;

public class uimanager1 : MonoBehaviour

{
    public GameObject Image;
    bool hehmahopen=false;
    // Start is called before the first frame update

   void Start() {
    Image.SetActive(false);
   }
    
    public void hehmah()
    {
        if(hehmahopen==false){Image.SetActive(true); 
        hehmahopen=true
        ;}
        else if(hehmahopen==true)
        {Image.SetActive(false);
        hehmahopen=false;}
        
        
    }
    

}

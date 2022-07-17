using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    // Start is called before the first frame update

    public PathCreator pathCreator;
    public float speed =5;
    float distanceTraveled;
    float timeSpan; 
    float checkTime;  // 특정 시간을 갖는 변수
    bool yes=false;
    public GameObject PlaneLight;


    

    //public GameObject ScrollArea;
    
  
void Start() {

     //PlaneLight.SetActive(false);
     //gameObject.SetActive(false);
     //gameObject.SetActive(true);

     //timeSpan=0.0f;
    //checkTime=10.0f;
     //Destroy(gameObject, 5);
}
    

    // Update is called once per frame
   
void Update() 
{
   
          if(yes==true){

             gameObject.SetActive(true);
       
         distanceTraveled+=speed*Time.deltaTime;
        transform.position=pathCreator.path.GetPointAtDistance(distanceTraveled);
        Destroy(gameObject, 5);
       
        StartCoroutine(Waitone());
        PlaneLight.SetActive(true);
        // Destroy(PlaneLight, 1.5f);
       
          
               
               }
}



    public void light()
    {

        yes=true;
        


    }

       IEnumerator Waitone()
        {

            yield return new WaitForSeconds(4.0f);
            
        }

     
}

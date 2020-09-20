using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateLevel : MonoBehaviour
{
    int[,] levelMap1 =
    {
    {1,2,2,2,2,2,2,2,2,2,2,2,2,7},{7,2,2,2,2,2,2,2,2,2,2,2,2,1},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,4},{4,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,4},{4,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,6,4,0,0,4,5,4,0,0,0,4,5,4},{4,5,4,0,0,0,4,5,4,0,0,4,6,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,3},{3,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,5},{5,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,3,3,5,3,4,4,4},{4,4,4,3,5,3,3,5,3,4,4,3,5,2},
    {2,5,3,4,4,3,5,4,4,5,3,4,4,3},{3,4,4,3,5,4,4,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,4,4,5,5,5,5,4},{4,5,5,5,5,4,4,5,5,5,5,5,5,2},
    {1,2,2,2,2,1,5,4,3,4,4,3,0,4},{4,0,3,4,4,3,4,5,1,2,2,2,2,1},
    {0,0,0,0,0,2,5,4,3,4,4,3,0,3},{3,0,3,4,4,3,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,4,0,0,0,0,0},{0,0,0,0,0,4,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,4,0,3,4,4,0},{0,4,4,3,0,4,4,5,2,0,0,0,0,0},
    {2,2,2,2,2,1,5,3,3,0,4,0,0,0},{0,0,0,4,0,3,3,5,1,2,2,2,2,2},
    {0,0,0,0,0,0,5,0,0,0,4,0,0,0},{0,0,0,4,0,0,0,5,0,0,0,0,0,0},
    };

    int[,] levelMap2 = 
    {  
    {2,2,2,2,2,1,5,3,3,0,4,0,0,0},{0,0,0,4,0,3,3,5,1,2,2,2,2,2},
    {0,0,0,0,0,2,5,4,4,0,3,4,4,0},{0,4,4,3,0,4,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,4,0,0,0,0,0},{0,0,0,0,0,4,4,5,2,0,0,0,0,0},
    {0,0,0,0,0,2,5,4,3,4,4,3,0,3},{3,0,3,4,4,3,4,5,2,0,0,0,0,0},
    {1,2,2,2,2,1,5,4,3,4,4,3,0,4},{4,0,3,4,4,3,4,5,1,2,2,2,2,1},
    {2,5,5,5,5,5,5,4,4,5,5,5,5,4},{4,5,5,5,5,4,4,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,4,4,5,3,4,4,3},{3,4,4,3,5,4,4,5,3,4,4,3,5,2},
    {2,5,3,4,4,3,5,3,3,5,3,4,4,4},{4,4,4,3,5,3,3,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,5},{5,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,3},{3,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,6,4,0,0,4,5,4,0,0,0,4,5,4},{4,5,4,0,0,0,4,5,4,0,0,4,6,2},
    {2,5,3,4,4,3,5,3,4,4,4,3,5,4},{4,5,3,4,4,4,3,5,3,4,4,3,5,2},
    {2,5,5,5,5,5,5,5,5,5,5,5,5,4},{4,5,5,5,5,5,5,5,5,5,5,5,5,2},
    {1,2,2,2,2,2,2,2,2,2,2,2,2,7},{7,2,2,2,2,2,2,2,2,2,2,2,2,1},
    };
    public GameObject[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        int i = 0; 
        int j = 0;
        foreach(int num in levelMap1){
            if(i == 28){ 
                i = 0;
                j--;
            }
            if(num == 1){
                if((i==0 && j==0)||(i==22&&j==-9)){
                    Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.identity);
                }else if((Mathf.Abs(i+j)==18)||(i==5 && j == -13)){
                    Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,180));
                }else if(Mathf.Abs(i+j)==9){
                    Instantiate(sprites[num],new Vector3(i,j,0), Quaternion.Euler(0,0,90));
                }else{
                    Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,270));
                }
            }
        

            if(num == 2){
                if(j==0 || j==-9 || j==-13){
                Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.Euler(0,0,90));
                 }else{
                Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.identity);
            }
            }

            if(num ==3){
                Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.identity);
            }

            if(num == 5){
                Instantiate(sprites[num],new Vector3(i,j,0),Quaternion.identity);
            }



           
            
            i++;
        }
        
        Instantiate(sprites[7],new Vector3(13,0,0),Quaternion.identity);
        GameObject temp1 =  Instantiate(sprites[7],new Vector3(14,0,0),Quaternion.identity) as GameObject; 
        temp1.transform.localScale = new Vector3(-1,1,1);
        GameObject temp2 =  Instantiate(sprites[7],new Vector3(13,-28,0),Quaternion.identity) as GameObject; 
        temp2.transform.localScale = new Vector3(-1,-1,1);
        GameObject temp3 =  Instantiate(sprites[7],new Vector3(14,-28,0),Quaternion.identity) as GameObject; 
        temp3.transform.localScale = new Vector3(1,-1,1);            
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

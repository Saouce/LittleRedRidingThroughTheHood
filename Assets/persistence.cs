using UnityEngine;

public class persistence : MonoBehaviour
{


    public void Awake(){
        if(GameManager.Instance.openingcutscene){
            Destroy(gameObject);
        }
        if(GameManager.Instance.huntsmanAxeitem){
            Destroy(gameObject);
        }
    }

    public void CollectItem(){
        GameManager.Instance.huntsmanAxeitem = true;
    }
    public void OpeningEndSceneCuts(){
        GameManager.Instance.openingcutscene = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IDragHandler, IEndDragHandler{
    public GameManager gameManager;
    public GameObject tutorialPanel;
    private Vector3 panelLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;
    public int totalPages = 1;
    private int currentPage = 2;

    // Start is called before the first frame update
    void Start(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        panelLocation = transform.position;
    }
    public void OnDrag(PointerEventData data){
        float difference = data.pressPosition.x - data.position.x;
        transform.position = panelLocation - new Vector3(difference, 0, 0);
    }
    public void OnEndDrag(PointerEventData data){
        float percentage = (data.pressPosition.x - data.position.x) / Screen.width;
        if(Mathf.Abs(percentage) >= percentThreshold){
            Vector3 newLocation = panelLocation;
            if(percentage > 0 && currentPage < totalPages){
                currentPage++;
                newLocation += new Vector3(-Screen.width, 0, 0);
            }else if(percentage < 0 && currentPage > 1){
                currentPage--;
                newLocation += new Vector3(Screen.width, 0, 0);
            }
            if(currentPage == 1 || currentPage == 5)
            {
                gameManager.tutotialIsCompleted = 1;
                PlayerPrefs.SetInt("TCompleted", 1);
                PlayerPrefs.Save();
                Destroy(tutorialPanel,1f);
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;
        }
        else{
            StartCoroutine(SmoothMove(transform.position, panelLocation, easing));
        }
    }
    public void NextMenu()
    {
            Vector3 newLocation = panelLocation;
            if(currentPage < totalPages){
                currentPage++;
                newLocation += new Vector3(-Screen.width, 0, 0);
            }
            if(currentPage == 1 || currentPage == 5)
            {
                gameManager.tutotialIsCompleted = 1;
                PlayerPrefs.SetInt("TCompleted", 1);
                PlayerPrefs.Save();
                Destroy(tutorialPanel,1f);
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;  
    }
    public void BackMenu()
    {
            Vector3 newLocation = panelLocation;
           if(currentPage > 1){
                currentPage--;
                newLocation += new Vector3(Screen.width, 0, 0);
            }
            if(currentPage == 1 || currentPage == 5)
            {
                gameManager.tutotialIsCompleted = 1;
                PlayerPrefs.SetInt("TCompleted", 1);
                PlayerPrefs.Save();
                Destroy(tutorialPanel,1f);
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;  
    }
    IEnumerator SmoothMove(Vector3 startpos, Vector3 endpos, float seconds){
        float t = 0f;
        while(t <= 1.0){
            t += Time.deltaTime / seconds;
            transform.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }
}

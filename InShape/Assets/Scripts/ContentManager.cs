using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ContentManager : MonoBehaviour
{
    public Toggle BirdToggle;
    public GameObject MamaBridPrefab;
    public GameObject BabyBridPrefab;
    private GameObject SpawnedBrid;
    public Camera ARCamera;
    private List<RaycastResult> raycastResults = new List<RaycastResult>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Debug.Log("Mouse Down!!");

            Ray ray = ARCamera.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);

            if (IsPointerOverUI(Input.mousePosition))
            {
                // Debug.Log("Do nothing");
            }
            else
            {
                SpawnedBrid = Instantiate(WhichBird(), ray.origin, Quaternion.identity);
                SpawnedBrid.GetComponent<Rigidbody>().AddForce(ray.direction * 100);
            }
        }
    }

    public GameObject WhichBird()
    {
        if (BirdToggle.isOn)
        {
            return MamaBridPrefab;
        }
        else
        {
            return BabyBridPrefab;
        }
    }

    private bool IsPointerOverUI(Vector2 fingerPosition)
    {
        PointerEventData eventDataPosition = new PointerEventData(EventSystem.current);
        eventDataPosition.position = fingerPosition;
        EventSystem.current.RaycastAll(eventDataPosition, raycastResults);
        return raycastResults.Count > 0;
    }
}

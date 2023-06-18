using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float DrivingDistance = 20f;
    public float DrivingSpeed = 1.5f; // Speed in m/s
    public float DrivingSpeedVariance = 1.5f; // Speed variance in m/s
    public float SpawnTimer = 2f;
    public float SpawnTimerVariance = 3f;

    private float timer = 0f;
    
    public GameObject InitialCar;
    private List<GameObject> Cars = new List<GameObject>();

    private Vector3 SpawnPosition;
    private Quaternion SpawnRotation;

    public float _spawntimer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPosition = gameObject.transform.position;
        SpawnRotation = gameObject.transform.rotation;

        SpawnCar();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        _spawntimer = SpawnTimer + Random.Range(0, SpawnTimerVariance);

        if (timer >= _spawntimer)
        {
            timer = 0f;
            SpawnCar();
        }


        foreach (GameObject Car in Cars)
        {
            float DistanceDriven = Mathf.Abs(SpawnPosition.x - Car.transform.position.x);
            
                float speed = DrivingSpeed + Random.Range(-DrivingSpeedVariance, DrivingSpeedVariance);
                Car.transform.Translate(Vector3.forward * speed * Time.deltaTime);


            
        }
    }


    private void SpawnCar()
    {
        GameObject newCar = Instantiate(InitialCar, SpawnPosition, SpawnRotation);
        Cars.Add(newCar);
        StartCoroutine(Destroy());
    }

    private void DeleteCar(GameObject Car)
    {
        Cars.Remove(Car);
        Destroy(Car);
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(21f);

        if(Cars.Count != 0)
        {
            foreach (GameObject Car in Cars)
            {
                DeleteCar(Car);
                break;
            }
        }

    }
}


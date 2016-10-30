using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PathMaker : MonoBehaviour
{

    int counter;
    float randInt;
    public Transform floorPrefab, oceanPrefab, mountPrefab;
    public Transform pathmakerSpherePrefab;
    public int behaviorVar;
    static int cubeCount;
    public int cubeCountResetter;
    public int counterCap;
    // Use this for initialization
    void Start()
    {
        counter = 0;
        behaviorVar = Random.Range(0, 6);
        cubeCount = cubeCountResetter;
        counterCap = Random.Range(20, 51);
    }

    // Update is called once per frame
    void Update()
    {

        cubeCountResetter = cubeCount;
        switch (behaviorVar)
        {
            case 0: //highly forested, somewhat mountainous, very rare water. high density.
                if (counter < counterCap && cubeCount <= 500)
                {
                    float randInt = Random.value;
                    float enviroVar = Random.value;

                    //controls movement of pathmaker
                    if (randInt < .25f)
                    {
                        transform.Rotate(0f, 90f, 0f);
                    }
                    else if (randInt > .25f && randInt < .5f)
                    {
                        transform.Rotate(0f, -90f, 0f);
                    }
                    else if (randInt > .9f && randInt < 1.0f)
                    {
                        Instantiate(pathmakerSpherePrefab, transform.position, Quaternion.identity);
                    }

                    //iterates accumulator variables per frame
                    transform.Translate(0f, 0f, 5f); //test to see if need time.deltatime
                    counter++;
                    cubeCount++;

                    //determines odds of spawning whichever tile type
                    if (enviroVar < .75f)
                    {
                        Instantiate(floorPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .85f && enviroVar < .95f)
                    {
                        Instantiate(mountPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .95f && enviroVar < 1.0f)
                    {
                        Instantiate(oceanPrefab, transform.position, Quaternion.identity);
                    }
                }
                else
                {
                    Destroy(gameObject);
                }
                break;

            case 1: //most common case. lots of grass, some mountains and little water. average to above average density.
                if (counter < counterCap && cubeCount <= 500)
                {
                    float randInt = Random.value;
                    float enviroVar = Random.value;

                    //controls movement of pathmaker
                    if (randInt < .25f)
                    {
                        transform.Rotate(0f, 90f, 0f);
                    }
                    else if (randInt > .25f && randInt < .5f)
                    {
                        transform.Rotate(0f, -90f, 0f);
                    }
                    else if (randInt > .9f && randInt < 1.0f)
                    {
                        Instantiate(pathmakerSpherePrefab, transform.position, Quaternion.identity);
                    }

                    //iterates accumulator variables per frame
                    transform.Translate(0f, 0f, 5f); //test to see if need time.deltatime
                    counter++;
                    cubeCount++;

                    //determines odds of spawning whichever tile type
                    if (enviroVar < .65f)
                    {
                        Instantiate(floorPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .65f && enviroVar < .7f)
                    {
                        Instantiate(mountPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .95f && enviroVar < 1.0f)
                    {
                        Instantiate(oceanPrefab, transform.position, Quaternion.identity);
                    }
                }
                else
                {
                    Destroy(gameObject);
                }
                break;

            case 2: //most common case. lots of grass, some mountains and little water. average to above average density.
                if (counter < counterCap && cubeCount <= 500)
                {
                    float randInt = Random.value;
                    float enviroVar = Random.value;

                    //controls movement of pathmaker
                    if (randInt < .25f)
                    {
                        transform.Rotate(0f, 90f, 0f);
                    }
                    else if (randInt > .25f && randInt < .5f)
                    {
                        transform.Rotate(0f, -90f, 0f);
                    }
                    else if (randInt > .9f && randInt < 1.0f)
                    {
                        Instantiate(pathmakerSpherePrefab, transform.position, Quaternion.identity);
                    }

                    //iterates accumulator variables per frame
                    transform.Translate(0f, 0f, 5f); //test to see if need time.deltatime
                    counter++;
                    cubeCount++;

                    //determines odds of spawning whichever tile type
                    if (enviroVar < .65f)
                    {
                        Instantiate(floorPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .65f && enviroVar < .7f)
                    {
                        Instantiate(mountPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .95f && enviroVar < 1.0f)
                    {
                        Instantiate(oceanPrefab, transform.position, Quaternion.identity);
                    }
                }
                else
                {
                    Destroy(gameObject);
                }
                break;

            case 3: //most common case. lots of grass, some mountains and little water. average to above average density.
                if (counter < counterCap && cubeCount <= 500)
                {
                    float randInt = Random.value;
                    float enviroVar = Random.value;

                    //controls movement of pathmaker
                    if (randInt < .25f)
                    {
                        transform.Rotate(0f, 90f, 0f);
                    }
                    else if (randInt > .25f && randInt < .5f)
                    {
                        transform.Rotate(0f, -90f, 0f);
                    }
                    else if (randInt > .9f && randInt < 1.0f)
                    {
                        Instantiate(pathmakerSpherePrefab, transform.position, Quaternion.identity);
                    }

                    //iterates accumulator variables per frame
                    transform.Translate(0f, 0f, 5f); //test to see if need time.deltatime
                    counter++;
                    cubeCount++;

                    //determines odds of spawning whichever tile type
                    if (enviroVar < .65f)
                    {
                        Instantiate(floorPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .65f && enviroVar < .7f)
                    {
                        Instantiate(mountPrefab, transform.position, Quaternion.identity);
                    }
                    else if (enviroVar > .95f && enviroVar < 1.0f)
                    {
                        Instantiate(oceanPrefab, transform.position, Quaternion.identity);
                    }
                }
                else
                {
                    Destroy(gameObject);
                }
                break;

            case 4: //one of two rare cases. extremely mountainous, with some ocean. no grass.
                if (counter < counterCap && cubeCount <= 500)
                {
                    float randInt = Random.value;
                    float enviroVar = Random.value;

                    //controls movement of pathmaker
                    if (randInt < .25f)
                    {
                        transform.Rotate(0f, 90f, 0f);
                    }
                    else if (randInt > .25f && randInt < .5f)
                    {
                        transform.Rotate(0f, -90f, 0f);
                    }
                    else if (randInt > .9f && randInt < 1.0f)
                    {
                        Instantiate(pathmakerSpherePrefab, transform.position, Quaternion.identity);
                    }

                    //iterates accumulator variables per frame
                    transform.Translate(0f, 0f, 5f); //test to see if need time.deltatime
                    counter++;
                    cubeCount++;

                    //determines odds of spawning whichever tile type
                    if (enviroVar < .7f)
                    {
                        Instantiate(mountPrefab, transform.position, Quaternion.identity);
                    }                   
                    else if (enviroVar > .9f && enviroVar < 1.0f)
                    {
                        Instantiate(oceanPrefab, transform.position, Quaternion.identity);
                    }
                }
                else
                {
                    Destroy(gameObject);
                }
                break;

            case 5: //ocean only. complete fill density.
                if (counter < counterCap && cubeCount <= 500)
                {
                    float randInt = Random.value;
                    float enviroVar = Random.value;

                    //controls movement of pathmaker
                    if (randInt < .25f)
                    {
                        transform.Rotate(0f, 90f, 0f);
                    }
                    else if (randInt > .25f && randInt < .5f)
                    {
                        transform.Rotate(0f, -90f, 0f);
                    }
                    else if (randInt > .9f && randInt < 1.0f)
                    {
                        Instantiate(pathmakerSpherePrefab, transform.position, Quaternion.identity);
                    }

                    //iterates accumulator variables per frame
                    transform.Translate(0f, 0f, 5f); //test to see if need time.deltatime
                    counter++;
                    cubeCount++;

                    //determines odds of spawning whichever tile type
                    if (enviroVar < 1.0f)
                    {
                        Instantiate(oceanPrefab, transform.position, Quaternion.identity);
                    }
                }
                else
                {
                    Destroy(gameObject);
                }
                break;
        }
        
    }
}

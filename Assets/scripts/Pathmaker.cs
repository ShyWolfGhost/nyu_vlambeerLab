using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

// MAZE PROC GEN LAB
// all students: complete steps 1-6, as listed in this file
// optional: if you're up for a bit of a mind safari, complete the "extra tasks" to do at the very bottom

// STEP 1: ======================================================================================
// put this script on a Sphere... it SHOULD move around, and drop a path of floor tiles behind it
/// <summary>
/// done
/// </summary>

public class Pathmaker : MonoBehaviour {


	
	
	
	
	// STEP 2: ============================================================================================
// translate the pseudocode below

//	DECLARE CLASS MEMBER VARIABLES:
//	Declare a private integer called counter that starts at 0; 		// counter will track how many floor tiles I've instantiated
	private int counter;//for floor tile
	public static int globalTileCOUNT;
	public int CounterMax;
	public int IDKCount;
	public int TWINXLCount;
	public int FANDOMCount;
	
	
	
	public TextMeshPro Meshy;

	public int tileRandom;
	public int tileTypenum;
//	Declare a public Transform called floorPrefab, assign the prefab in inspector;
	//public Transform Floorprefab;
	public Transform idkTileprefab;
	public bool wasGenerated = false;
	
	public Transform Xlprefab;
	public Transform Fandomprefab;
	
	
//	Declare a public Transform called pathmakerSpherePrefab, assign the prefab in inspector; 		// you'll have to make a "pathmakerSphere" prefab later
	public Transform pathmakerSpherePrefab;
	public GameObject pathmakerSpherePrefabOBJECT;//sphere
	void Start()
	{
		CounterMax = Random.Range(50, 300);
		Meshy.text = " ";

	}


	void Update ()
	{
		/*if (Input.GetKey(KeyCode.R)&& wasGenerated == true)
		{
			Debug.Log("R Key Pressed");
			SceneManager.LoadScene("IMadeMySelf");
		}
		*/
		Debug.Log("Global COUNTER: " + counter);

		Debug.Log("COUNTER: " + counter);
//		If counter is less than 50, then:
	if(globalTileCOUNT<600)
	{
		
		if (counter < CounterMax)
		{

			float randomFloat = Random.Range(0.0f, 1.0f);
			tileRandom = Random.Range(0, tileTypenum);
			Debug.Log("RandomFloat: " + randomFloat);

//			Generate a random number from 0.0f to 1.0f;


			if (randomFloat <= 0.279f)
			{
				pathmakerSpherePrefab.Rotate(0, 90, 0);
				Debug.Log("+90");
//			If random number is less than 0.25f, then rotate myself 90 degrees;

			}

			else if (randomFloat >= .3f && randomFloat <= 0.6f)
			{
				pathmakerSpherePrefab.Rotate(0, -90, 0);
				Debug.Log("+90");

				//				... Else if number is 0.25f-0.5f, then rotate myself -90 degrees;
			}
			else if (randomFloat >= 0.9f && randomFloat <= 1f)
			{
				Instantiate(pathmakerSpherePrefab, pathmakerSpherePrefab.transform.position, Quaternion.identity);
				Debug.Log(".o99-1 WTF");
				//Instantiate(pathmakerSpherePrefab,??????,Quaternion.identity);

				//				... Else if number is 0.99f-1.0f, then instantiate a pathmakerSpherePrefab clone at my current position;
			}

//			// end elseIf

			ChooseATile();
			
			
			counter = counter + 1;
//			Instantiate a floorPrefab clone at current position;
//			Move forward ("forward", as in, the direction I'm currently facing) by 5 units;
			pathmakerSpherePrefab.Translate(Vector3.forward *9);
			//pathmakerSpherePrefab.transform.positon + forward(0, 0, 5);
//z=404ward
//			Increment counter;
//		Else:
//			Destroy my game object; 		// self destruct if I've made enough tiles already
		}

		globalTileCOUNT = globalTileCOUNT +1;
	}

	else

	{
		Destroy(pathmakerSpherePrefabOBJECT);
		//pathmakerSpherePrefabOBJECT.SetActive(false);
		Debug.Log("KA-BOOM");
		//wasGenerated = true;
		//Meshy.text = "Congratulations. Press the R key to restart.";//There are " + IDKCount + " iDKHOW tiles, " + TWINXLCount +
		//" TwinXL tiles, and " + FANDOMCount + " Fandom tiles for a total of " + globalTileCOUNT +
			//" tiles in the scene.
		
	}
	}

	void ChooseATile()
	{
		//tileRandom=tileRandom
		if (tileRandom ==0&&tileRandom<1)
		{
			Instantiate(idkTileprefab, pathmakerSpherePrefab.transform.position, Quaternion.identity);
			Debug.Log("IDK TILE PLACED");
			IDKCount = IDKCount + 1;
		}
		else if (tileRandom==1&&tileRandom<2)
         		{
         			Instantiate(Xlprefab, pathmakerSpherePrefab.transform.position, Quaternion.identity);
         			Debug.Log("XL Tile Placed");
                    TWINXLCount = TWINXLCount + 1;
         		}
		else if (tileRandom==2&&tileRandom<=3)
		{
			Instantiate(Fandomprefab, pathmakerSpherePrefab.transform.position, Quaternion.identity);
			Debug.Log("Fandom Tile Placed");
			FANDOMCount = FANDOMCount + 1;
		}

		
	}
} 


// MORE STEPS BELOW!!!........

// STEP 3: =====================================================================================
// implement, test, and stabilize the system

//	IMPLEMENT AND TEST:
//	- save your scene! the code could potentially be infinite / exponential, and crash Unity
//	- put Pathmaker.cs on a sphere, configure all the prefabs in the Inspector, and test it to make sure it works
//	STABILIZE: 
//	- code it so that all the Pathmakers can only spawn a grand total of 500 tiles in the entire world; how would you do that?
//	- hint: declare a "public static int" and have each Pathmaker check this "globalTileCount", somewhere in your code? 
//      -  What is a 'static'?  Static???  Simply speak the password "static" to the instructor and knowledge will flow.
//	- Perhaps... if there already are enough tiles maybe the Pathmaker could Destroy my game object

// STEP 4: ======================================================================================
// tune your values...

// a. how long should a pathmaker live? etc.  (see: static  ---^)
// b. how would you tune the probabilities to generate lots of long hallways? does it... work?
// c. tweak all the probabilities that you want... what % chance is there for a pathmaker to make a pathmaker? is that too high or too low?



// STEP 5: ===================================================================================
// maybe randomize it even more?

// - randomize 2 more variables in Pathmaker.cs for each different Pathmaker... you would do this in Start()
// - maybe randomize each pathmaker's lifetime? maybe randomize the probability it will turn right? etc. if there's any number in your code, you can randomize it if you move it into a variable



// STEP 6:  =====================================================================================
// art pass, usability pass

// - move the game camera to a position high in the world, and then point it down, so we can see your world get generated
// - CHANGE THE DEFAULT UNITY COLORS
// - add more detail to your original floorTile placeholder -- and let it randomly pick one of 3 different floorTile models, etc. so for example, it could randomly pick a "normal" floor tile, or a cactus, or a rock, or a skull
// - or... make large city tiles and create a city.  Set the camera low so and une the values so the city tiles get clustered tightly together.

//		- MODEL 3 DIFFERENT TILES IN BLENDER.  CREATE SOMETHING FROM THE DEEP DEPTHS OF YOUR MIND TO PROCEDURALLY GENERATE. 
//		- THESE TILES CAN BE BASED ON PAST MODELS YOU'VE MADE, OR NEW.  BUT THEY NEED TO BE UNIQUE TO THIS PROJECT AND CLEARLY TILE-ABLE.

//		- then, add a simple in-game restart button; let us press [R] to reload the scene and see a new level generation
// - with Text UI, name your proc generation system ("AwesomeGen", "RobertGen", etc.) and display Text UI that tells us we can press [R]


// OPTIONAL EXTRA TASKS TO DO, IF YOU WANT / DARE: ===================================================

// AVOID SPAWNING A TILE IN THE SAME PLACE AS ANOTHER TILE  https://docs.unity3d.com/ScriptReference/Physics.OverlapSphere.html
// Check out the Physics.OverlapSphere functionality... 
//     If the collider is overlapping any others (the tile prefab has one), prevent a new tile from spawning and move forward one space. 

// DYNAMIC CAMERA:
// position the camera to center itself based on your generated world...
// 1. keep a list of all your spawned tiles
// 2. then calculate the average position of all of them (use a for() loop to go through the whole list) 
// 3. then move your camera to that averaged center and make sure fieldOfView is wide enough?

// BETTER UI:
// learn how to use UI Sliders (https://unity3d.com/learn/tutorials/topics/user-interface-ui/ui-slider) 
// let us tweak various parameters and settings of our tech demo
// let us click a UI Button to reload the scene, so we don't even need the keyboard anymore.  Throw that thing out!

// WALL GENERATION
// add a "wall pass" to your proc gen after it generates all the floors
// 1. raycast downwards around each floor tile (that'd be 8 raycasts per floor tile, in a square "ring" around each tile?)
// 2. if the raycast "fails" that means there's empty void there, so then instantiate a Wall tile prefab
// 3. ... repeat until walls surround your entire floorplan
// (technically, you will end up raycasting the same spot over and over... but the "proper" way to do this would involve keeping more lists and arrays to track all this data)

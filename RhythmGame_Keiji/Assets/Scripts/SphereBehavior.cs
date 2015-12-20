using UnityEngine;
using System.Collections;
using SynchronizerData;


public class SphereBehavior : MonoBehaviour {

	public Vector3[] beatPositions;

	public GameObject Obstacle;
	private BeatObserver beatObserver;
	private int beatCounter;


	void Start ()
	{
		beatObserver = GetComponent<BeatObserver>();
		beatCounter = 0;
	}

	void Update ()


	{
		GameObject Clone;
		if ((beatObserver.beatMask & BeatType.OnBeat) == BeatType.OnBeat) {
			transform.position = beatPositions[beatCounter];
			beatCounter = (++beatCounter == beatPositions.Length ? 0 : beatCounter);
			Clone = (Instantiate (Obstacle, transform.position, transform.rotation)) as GameObject;
		}
	}
}

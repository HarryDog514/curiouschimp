using UnityEngine;
using UnityEngine.AI;

public class AIMoveshortDis : MonoBehaviour

{
	private NavMeshAgent Mob;

	private GameObject[] Players;

	public float MobDistanceRun = 4f;

	public Animator Animator;

	public AudioSource chasing;

	[SerializeField] public string AnimationName;

	private void Start()
	{
		Mob = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		Players = GameObject.FindGameObjectsWithTag("Player");
		Transform closestEnemy = GetClosestEnemy(Players);
		float num = Vector3.Distance(base.transform.position, closestEnemy.position);
		if (num < MobDistanceRun)
		{
			Vector3 vector = base.transform.position - closestEnemy.position;
			Vector3 destination = base.transform.position - vector;
			Mob.SetDestination(destination);
			Animator.enabled = true;
			Animator.Play(AnimationName);
			chasing.enabled = true;
		}
		else
        {
			Animator.enabled = false;
			chasing.enabled = false;
		}
	}

	private Transform GetClosestEnemy(GameObject[] enemies)
	{
		Transform result = null;
		float num = float.PositiveInfinity;
		Vector3 position = base.transform.position;
		foreach (GameObject gameObject in enemies)
		{
			float num2 = Vector3.Distance(gameObject.transform.position, position);
			if (num2 < num)
			{
				result = gameObject.transform;
				num = num2;
			}
		}
		return result;
	}
}
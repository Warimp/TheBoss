using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float m_health;
	public float m_walkSpeed = 5f;
	
	

	private Animator m_animator;
	private CharacterController m_characterController;
	private Rigidbody m_rb;
	private AudioSource m_audio;

	void Start() {
		m_rb = GetComponent<Rigidbody>();
		m_audio = GetComponent<AudioSource>();
		m_characterController = GetComponent<CharacterController>();
		m_animator = GetComponent<Animator>();
	}


	void Update() {
		Vector3 m_moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		m_characterController.SimpleMove(m_moveDirection * m_walkSpeed);

	}



}
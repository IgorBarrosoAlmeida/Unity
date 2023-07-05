using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour {
	[SerializeField] private GameObject telaGameOver;
	private Aviao aviao;
	private Pontuacao pontuacao;

	private void Start() {
		this.aviao = GameObject.FindObjectOfType<Aviao>();
		this.pontuacao = FindObjectOfType<Pontuacao>();
	}


	public void stop() {
		Time.timeScale = 0;
		this.telaGameOver.SetActive(true);
	}
	
	public void ReiniciarJogo() {
		this.telaGameOver.SetActive(false);
		Time.timeScale = 1;
		this.aviao.Reiniciar();
		this.pontuacao.Reiniciar();
		this.DestruirObstaculos();
	}

	private void DestruirObstaculos() {
		Obstaculo[] obstaculos = FindObjectsOfType<Obstaculo>();

		foreach(Obstaculo o in obstaculos) {
			o.Destruir();
		}
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionCombos : MonoBehaviour {

	// Function for determining the output of two emotion combinations:
	public static string tryCombo(GameObject emotionL, GameObject emotionR) {
		string result = "nope";
		string L = null;
		string R = null;
		if (emotionL != null) {
			L = emotionL.GetComponent<Emotion>().emotionType;
		}

		if (emotionR != null) {
			R = emotionR.GetComponent<Emotion> ().emotionType;
		}

		if (L != null && R != null) {
			switch (R) {
			// JOY &
			case "JOY":
				switch (L) {
				// Unique
				case "JOY":
					result = "ECS";
					return result;
				case "SAD":
					result = "MEL";
					return result;
				case "FEA":
					result = "SUR";
					return result;
				default:
					result = "nope";
					return result;
				}
			// SADNESS &
			case "SAD":
				switch (L) {
				case "JOY":
					result = "MEL";
					return result;
				// Unique
				case "SAD":
					result = "DES";
					return result;
				case "FEA":
					result = "ANX";
					return result;
				default:
					result = "nope";
					return result;
				}
			// FEAR &
			case "FEA":
				switch (L) {
				case "JOY":
					result = "SUR";
					return result;
				case "SAD":
					result = "ANX";
					return result;
				// Unique
				case "FEA":
					result = "TER";
					return result;
				default:
					result = "nope";
					return result;
				}
			default:
				result = "nope";
				return result;
			}
		}
		else {
			return result;
		}
	}
}

			//      JOY
		    //      SAD
		    //      FEA
			//		J+J = Ecstasy    ECS
			//		S+S = Despair    DES
			//		J+F = Surprise   SUR
			//		F+F = Terror     TER
			//		F+S = Anxiety    ANX
			//		J+S = Melancholy MEL


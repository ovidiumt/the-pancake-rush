using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMeniu : MonoBehaviour
{	

	Resolution[] resolutions;
	public TMP_Dropdown resolutionsDropDownMeniu;

	void Start(){
		int userResolutionIndex = 0;

		resolutions = Screen.resolutions;

		resolutionsDropDownMeniu.ClearOptions();

		List<string> listOfOptions = new List<string>();


		for(int i = 0 ; i< resolutions.Length ; i++){
			string option = resolutions[i].width + "x" + resolutions[i].height;
			listOfOptions.Add(option);

			if((resolutions[i].width == Screen.currentResolution.width) && (resolutions[i].height == Screen.currentResolution.height)){
				userResolutionIndex = i;
			}
		}

		resolutionsDropDownMeniu.AddOptions(listOfOptions);
		resolutionsDropDownMeniu.value = userResolutionIndex;
		resolutionsDropDownMeniu.RefreshShownValue();
	}

	public void SetResolution(int resolutionIndex){
		Resolution resolution = resolutions[resolutionIndex];

		Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
	}

	//ramane de implementat dupa ce adaugam audio in joc
 	public void SetVolume(float volume){
 		Debug.Log(volume);
 	}

 	public void setFullScreen(bool isFullScreen){
 		Screen.fullScreen = isFullScreen;
 	}
}

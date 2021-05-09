using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public Sounds[] sounds;
	public Transform player;
	private bool is_Playingsecond = false, is_Playingfirst = false;

	public static AudioManager instance;
    // Start is called before the first frame update
    void Awake()
    {	

    	if(instance == null) instance = this;
    	else {
    		Destroy(gameObject);
    		return;
    	}
    	DontDestroyOnLoad(gameObject);

        foreach(Sounds s in sounds){
        	s.source = gameObject.AddComponent<AudioSource>();
        	s.source.clip = s.clip;
        	s.source.volume = s.volume;
        	s.source.pitch = s.pitch;
        	s.source.loop = s.loop;
        }
    }

    void Start(){
    	Play("MainTheme"); 
    	is_Playingfirst = true;
    }

    void Update(){
    	if(player.position.y <= -2 && !is_Playingsecond) {
    		Stop("MainTheme");
    		Play("CaveTheme");
    		is_Playingsecond = true;
    		is_Playingfirst = false;
    	}else if(player.position.y >= -2 && !is_Playingfirst){
    		Stop("CaveTheme");
    		Play("MainTheme");
    		is_Playingsecond = false;
    		is_Playingfirst = true;
    	}
    }

    public void Play(string name){
    	Sounds s = Array.Find(sounds, sound => sound.name == name);

    	if(s == null) return;

    	s.source.Play();
    }

    public void Stop(string name){
    	Sounds s = Array.Find(sounds, sound => sound.name == name);

    	if(s == null) return;

    	s.source.Stop();
    }
}

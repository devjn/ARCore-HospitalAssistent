using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Watson.DeveloperCloud.Services.TextToSpeech.v1;
using IBM.Watson.DeveloperCloud.DataTypes;
using IBM.Watson.DeveloperCloud.Utilities;
using IBM.Watson.DeveloperCloud.Logging;
using IBM.Watson.DeveloperCloud.Connection;
using System.IO;
using FullSerializer;

public class TextToSpeechLib : MonoBehaviour {
	private TextToSpeech _textToSpeech;

	public TextToSpeechLib() {
		Credentials credentials = new Credentials("f3301f55-3a1c-4c38-8ad3-963ca59b0c11", "anWzY2bkDPhU", "https://stream.watsonplatform.net/text-to-speech/api");
		this._textToSpeech = new TextToSpeech(credentials);
	}

	private void OnSynthesize(AudioClip clip, Dictionary<string, object> customData)
	{
		PlayClip(clip);
	}

	private void PlayClip(AudioClip clip)
	{
		if (Application.isPlaying && clip != null)
		{
			GameObject audioObject = new GameObject("AudioObject");
			AudioSource source = audioObject.AddComponent<AudioSource>();
			source.spatialBlend = 0.0f;
			source.loop = false;
			source.clip = clip;
			source.Play();

			Destroy(audioObject, clip.length);
		}
	}

    private void OnFail(RESTConnector.Error error, Dictionary<string, object> customData)
    {
        Log.Error("ExampleSpeechToText.OnFail()", "Error received: {0}", error.ToString());
    }

    public void Convert(string Text) {
		this._textToSpeech.Voice = VoiceType.en_US_Allison;
		if(!this._textToSpeech.ToSpeech(OnSynthesize, OnFail, Text, true))
			Log.Debug("ExampleTextToSpeech.ToSpeech()", "Failed to synthesize!");
		
	}
}
